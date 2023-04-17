using System;
using UnityEngine;

namespace config
{
    [Serializable]
    public class Balance
    {
        public BalanceConfig BalanceValue;

        public Balance(BalanceConfig config)
        {
            //todo Настроить баланас
            //BalanceValue = config.Balance;
        }
    }
}