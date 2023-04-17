using UnityEngine;

namespace config
{
    [CreateAssetMenu(menuName = nameof(BalanceConfig))]
    public class BalanceConfig: ScriptableObject
    {
        public Balance Balance => _balance;
        [SerializeField] private Balance _balance;
        
    }
}