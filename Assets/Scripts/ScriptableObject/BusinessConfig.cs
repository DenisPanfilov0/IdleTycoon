using UnityEngine;

/// <summary>
/// Конфиг создаваемый под каждый бизнес отдельно
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

    [SerializeField] private float _initialLevel = 1f;
    [SerializeField] private float _baseLevelPrice = 3f;
    [SerializeField] private float _baseProfitBusiness = 3f;
    [SerializeField] private float _firstImprovement = 10f;
    [SerializeField] private float _secondImprovement = 100f;
    [SerializeField] private float _delay = 3f;
    [SerializeField] private string _businessName = "Mine";
}
