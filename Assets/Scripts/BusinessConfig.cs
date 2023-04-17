using UnityEngine;

/// <summary>
/// Конфиг
/// </summary>
[CreateAssetMenu(menuName = nameof(BusinessConfig))]
public class BusinessConfig : ScriptableObject
{
    public int InitialLevel => _initialLevel;       //начальный уровень =
    public float BaseLevelPrice => _baseLevelPrice;       //цена базового уровня =
    public float CurrentProfitBusiness => _currentProfitBusiness;
    public float BaseProfitBusiness => _baseProfitBusiness;
    public float LevelPrice => _levelPrice;
        
    [SerializeField] private int _initialLevel = 1;
    [SerializeField] private float _baseLevelPrice = 3;
    [SerializeField] private float _levelPrice;
    [SerializeField] private float _currentProfitBusiness = 0;
    [SerializeField] private float _baseProfitBusiness = 3;
}
