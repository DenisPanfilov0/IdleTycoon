using System;
using config;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// Контроллер - пересылает нажатие кнопок или другие события в модель
/// </summary>
public class BusinessController : MonoBehaviour
{

    private BusinessModel _model;
    private BusinessConfig BusinessConfig;
    // public BalanceConfig _config;
    [SerializeField] private TextMeshProUGUI _currentLevelBusinessText;
    [SerializeField] private TextMeshProUGUI _currentBusinessProfitText;
    [SerializeField] private TextMeshProUGUI _levelUpPriceText;
    
    [SerializeField]private ChangeButtonActivity _changeButtonActivity;


    private void Start()
    {
        
        BusinessConfig = ScriptableObject.CreateInstance<BusinessConfig>();
        //Config = Resources.Load<BusinessConfig>("BusinessConfig");
        _model = new BusinessModel(BusinessConfig);


    }

    private void Update()
    {

        _currentLevelBusinessText.text = _model.CurrentLevel.ToString();
        _currentBusinessProfitText.text = _model.CurrentProfit.ToString();
        _levelUpPriceText.text = _model.LevelUpPrice.ToString();
        if (_model.CurrentLevel == 5f)
        {
            _changeButtonActivity.ChangeButtonMaxLevel();
        }
        
    }

    public void OnUpgradeButtonClick()
    {
        _model.UpgradeLevel();
        
    }
}