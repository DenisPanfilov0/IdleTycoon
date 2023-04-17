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
    public float CurrentProfitBusiness => _currentProfitBusiness;
    public float BaseProfitBusiness => _baseProfitBusiness;
    public float LevelUpPrice => levelUpPrice;
        
    [SerializeField] private float _initialLevel = 1;
    [SerializeField] private float _baseLevelPrice = 3;
    [SerializeField] private float levelUpPrice;
    [SerializeField] private float _currentProfitBusiness;
    [SerializeField] private float _baseProfitBusiness = 3;
}
