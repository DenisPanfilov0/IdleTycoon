using UnityEngine;

/// <summary>
/// Контроллер - пересылает нажатие кнопок или другие события в модель или во View (патерн MVC)
/// </summary>
public class BusinessController : MonoBehaviour
{
    [SerializeField] private BusinessConfig _businessConfig;
    public BusinessModel _model;
    private BusinessViewModel _view;
/// <summary>
/// экономичнее отрисовать View один раз и обновлять не в Update,а в методах с изменениями
/// </summary>
    private void Start()
    {
        _model = new BusinessModel(_businessConfig);
        _view = GetComponent<BusinessViewModel>();
        _view.SetLevel(_model.CurrentLevel);
        _view.SetBusinessName(_model.BusinessName);
        _view.SetProfit(_model.CurrentProfit);
        _view.SetLevelUpPrice(_model.LevelUpPrice);
        _view.SetFirstImprovementPrice(_model.BaseLevelUpPrice * 10);
        _view.SetSecondImprovementPrice(_model.BaseLevelUpPrice * 20);
        _view.SetFirstImprovement(_model.FirstImprovement);
        _view.SetSecondImprovement(_model.SecondImprovement);
    }

    private void Update()
    {
        _view.SetProgress();
        if (_view.CurrentProgress >= 1)
        {
            Balance.Instance.BalanceValue += _model.CurrentProfit;
        }
        if (_model.CurrentLevel == 5f)
        {
            _view.DisableUpgradeButton();
        }
    }

    public void OnUpgradeButtonClick()
    {
        _model.UpgradeLevelButton();
        _view.SetLevel(_model.CurrentLevel);
        _view.SetProfit(_model.CurrentProfit);
        _view.SetLevelUpPrice(_model.LevelUpPrice);
    }

    public void OnFirstImprovementButtonClick()
    {
        _model.FirstImprovementButton();
        _view.DisableFirstImprovementButton();
        _view.SetProfit(_model.CurrentProfit);
    }

    public void OnSecondImprovementButtonClick()
    {
        _model.SecondImprovementButton();
        _view.DisableSecondImprovementButton();
        _view.SetProfit(_model.CurrentProfit);
    }
}