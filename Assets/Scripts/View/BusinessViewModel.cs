using TMPro;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// View. Вью - описывает и отрисовывает все визуальные части игры
/// </summary>
public class BusinessViewModel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _percentProgressText;
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _currentLevelBusinessText;
    [SerializeField] private TextMeshProUGUI _currentBusinessProfitText;
    [SerializeField] private TextMeshProUGUI _levelUpPriceText;
    [SerializeField] private TextMeshProUGUI _firstImprovementPriceText;
    [SerializeField] private TextMeshProUGUI _firstImprovementText;
    [SerializeField] private TextMeshProUGUI _secondImprovementPriceText;
    [SerializeField] private TextMeshProUGUI _secondImprovementText;
    [SerializeField] private ChangeButtonActivity _changeButtonActivity;
    [SerializeField] private TextMeshProUGUI _businessName;
    private float _progressTarget = 1f;
    private float _progressSpeed;
    private BusinessController _businessController;
    private float _currentProgress = 0f;

    public float CurrentProgress
    {
        get => _currentProgress;
        set => _currentProgress = value;
    }

    private void Start()
    {
        _businessController = GetComponent<BusinessController>();
    }

    public void SetProgress(/*float progress*/)
    {
        _slider.value = _currentProgress;
        _percentProgressText.text = Mathf.RoundToInt(_currentProgress * 100).ToString() + "%";
        if ((_currentProgress < _progressTarget) && _businessController._model.CurrentLevel >= 1)
        {
            _progressSpeed = 1.0f / _businessController._model.Delay;
            _currentProgress += _progressSpeed * Time.deltaTime;
            _currentProgress = Mathf.Clamp01(_currentProgress);
        }
        else
        {
            _currentProgress = 0;
        }
    }

    public void SetLevel(float level)
    {
        _currentLevelBusinessText.text = level.ToString();
    }

    public void SetProfit(float profit)
    {
         _currentBusinessProfitText.text = profit.ToString();
    }

    public void SetLevelUpPrice(float price)
    {
        _levelUpPriceText.text = price.ToString("F0");
    }

    public void SetFirstImprovementPrice(float price)
    {
        _firstImprovementPriceText.text = price.ToString();
    }

    public void SetFirstImprovement(float improvement)
    {
        _firstImprovementText.text = "+" + improvement.ToString();
    }

    public void SetSecondImprovementPrice(float price)
    {
        _secondImprovementPriceText.text = price.ToString();
    }

    public void SetSecondImprovement(float improvement)
    {
        _secondImprovementText.text = "+" + improvement.ToString() + "%";
    }

    public void SetBusinessName(string nameBusiness)
    {
        _businessName.text = nameBusiness;
    }

    public void DisableUpgradeButton()
    {
         _changeButtonActivity.ChangeButtonMaxLevel();
    }

    public void DisableFirstImprovementButton()
    {
         _changeButtonActivity.ChangeButtonFirstEmprovement();
    }

    public void DisableSecondImprovementButton()
    {
         _changeButtonActivity.ChangeButtonSecondEmprovement();
    }
}