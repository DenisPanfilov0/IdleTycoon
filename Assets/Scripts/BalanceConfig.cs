using UnityEngine;

namespace config
{
    [CreateAssetMenu(menuName = nameof(BalanceConfig))]
    public class BalanceConfig: ScriptableObject
    {
        public float Balance => _balance;
        [SerializeField] private float _balance;
        
    }
}