using UnityEngine;

/// <summary>
/// Конфиг
/// </summary>
[CreateAssetMenu(menuName = nameof(BusinessConfig))]
public class BusinessConfig : ScriptableObject
{
    public float InitialLevel => _initialLevel;       
    public float BaseLevelPrice => _baseLevelPrice;       
    public float BaseProfitBusiness => _baseProfitBusiness;
    public float FirstImprovement => _firstImprovement;
    public float SecondImprovement => _secondImprovement;
    public float Delay => _delay;
    public string BusinessName => _businessName;

    [SerializeField] private float _initialLevel = 1;
    [SerializeField] private float _baseLevelPrice = 3;
    [SerializeField] private float _baseProfitBusiness = 3;
    [SerializeField] private float _firstImprovement;
    [SerializeField] private float _secondImprovement;
    [SerializeField] private float _delay;
    [SerializeField] private string _businessName;
}
