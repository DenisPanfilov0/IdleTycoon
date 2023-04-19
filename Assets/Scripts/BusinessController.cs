using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Контроллер - пересылает нажатие кнопок или другие события в модель
/// </summary>
public class BusinessController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _PercentProgressText;
    [SerializeField] private TextMeshProUGUI _currentLevelBusinessText;
    [SerializeField] private TextMeshProUGUI _currentBusinessProfitText;
    [SerializeField] private TextMeshProUGUI _levelUpPriceText;
    [SerializeField] private TextMeshProUGUI _firstImprovementPriceText;
    [SerializeField] private TextMeshProUGUI _firstImprovementText;
    [SerializeField] private TextMeshProUGUI _secondImprovementPriceText;
    [SerializeField] private TextMeshProUGUI _secondImprovementText;
    [SerializeField] private ChangeButtonActivity _changeButtonActivity;
    [SerializeField] private BusinessConfig BusinessConfig;
    [SerializeField] private TextMeshProUGUI _businessName;
    [SerializeField] private Slider Slider;
    private BusinessModel _model;
    public float currentProgress;
    private float progressTarget = 1.0f;
    private float progressSpeed;

    private void Start()
    {
        currentProgress = 0f;
        _model = new BusinessModel(BusinessConfig);
        Slider.value = currentProgress;
        _firstImprovementPriceText.text = (_model.BaseLevelUpPrice * 10).ToString();
        _firstImprovementText.text = "+" + _model.FirstImprovement.ToString();
        _secondImprovementPriceText.text = (_model.BaseLevelUpPrice * 20).ToString();
        _secondImprovementText.text = "+" + _model.SecondImprovement.ToString() + "%";
        _businessName.text = _model.BusinessName;
    }

    private void Update()
    {
        Slider.value = currentProgress;
        _PercentProgressText.text = Mathf.RoundToInt(/*_businessController.*/currentProgress * 100).ToString() + "%";

        if (currentProgress < progressTarget && _model.CurrentLevel >= 1)
        {
            progressSpeed = 1.0f / _model.Delay;
            currentProgress += progressSpeed * Time.deltaTime;
            currentProgress = Mathf.Clamp01(currentProgress);
        }
        else if (_model.CurrentLevel >= 1)
        {
            currentProgress = 0f;
            Balance.Instance.BalanceValue += _model.CurrentProfit;
        }
        
        _currentLevelBusinessText.text = _model.CurrentLevel.ToString();
        _currentBusinessProfitText.text = _model.CurrentProfit.ToString();
        _levelUpPriceText.text = _model.LevelUpPrice.ToString("F0");
        if (_model.CurrentLevel == 5f)
        {
            _changeButtonActivity.ChangeButtonMaxLevel();
        }
    }

    public void OnUpgradeButtonClick()
    {
        _model.UpgradeLevelButton();
    }

    public void OnFirstImprovementButtonClick()
    {
        _model.FirstImprovementButton();
        _changeButtonActivity.ChangeButtonFirstEmprovement();
    }    
    
    public void OnSecondImprovementButtonClick()
    {
        _model.SecondImprovementButton();
        _changeButtonActivity.ChangeButtonSecondEmprovement();
    }
}