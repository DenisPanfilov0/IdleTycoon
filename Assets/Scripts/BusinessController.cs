using System;
using config;
using DefaultNamespace;
using TMPro;
using UnityEngine;

/// <summary>
/// Контроллер - пересылает нажатие кнопок или другие события в модель
/// </summary>
public class BusinessController : MonoBehaviour
{

    public BusinessModel _model;
    public BusinessConfig config;
    public BalanceConfig _config;
    [SerializeField] private TextMeshProUGUI _currentLevelBusinessText;
    [SerializeField] private TextMeshProUGUI _currentBusinessProfitText;
    [SerializeField] private TextMeshProUGUI _currentBalanceText;
    [SerializeField] private TextMeshProUGUI _levelUpPriceText;
    [SerializeField] private Balance _balance;

    private void Start()
    {
        config = new BusinessConfig();
        _model = new BusinessModel(config);
        _balance = new Balance(_config);
    }

    private void Update()
    {
        _currentLevelBusinessText.text = _model.CurrentLevel.ToString();
        _currentBusinessProfitText.text = _model.CurrentProfit.ToString();
        _currentBalanceText.text = _balance.BalanceValue.ToString();
        _levelUpPriceText.text = _model.LevelUpPrice.ToString();
    }


    public void OnUpgradeButtonClick()
    {
        //Debug.Log(_balance.ToString());
        _model.UpgradeLevel();
        _currentLevelBusinessText.text = _model.CurrentLevel.ToString();
        _currentBusinessProfitText.text = _model.CurrentProfit.ToString();
        //_balance.BalanceValue -= _model.BaseLevelPrice;


    }
}