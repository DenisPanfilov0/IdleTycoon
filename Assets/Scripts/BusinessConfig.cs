using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// Конфиг
/// </summary>
[CreateAssetMenu(menuName = nameof(BusinessConfig))]
public class BusinessConfig : ScriptableObject
{
    public float InitialLevel => _initialLevel;       //начальный уровень =
    public float BaseLevelPrice => _baseLevelPrice;       //цена базового уровня =
    //public float CurrentProfitBusiness => _currentProfitBusiness;
    public float BaseProfitBusiness => _baseProfitBusiness;
    //public float LevelUpPrice => _levelUpPrice;
    public float FirstImprovement => _firstImprovement;
    public float SecondImprovement => _secondImprovement;
    public float Delay => _delay;
    public string BusinessName => _businessName;
        
    [SerializeField] private float _initialLevel = 1;
    [SerializeField] private float _baseLevelPrice = 3;
    //[SerializeField] private float _levelUpPrice;
    //[SerializeField] private float _currentProfitBusiness;
    [SerializeField] private float _baseProfitBusiness = 3;
    [SerializeField] private float _firstImprovement;
    [SerializeField] private float _secondImprovement;
    [SerializeField] private float _delay;
    [SerializeField] private string _businessName;
}
