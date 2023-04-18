using System;
using config;
using UnityEngine;

namespace DefaultNamespace
{
    /// <summary>
    /// Текущая прокачка
    /// </summary>
    public class BusinessModel 
    {
        public float CurrentLevel { get; private set; }
        public float BaseLevelUpPrice { get; private set; }
        public float CurrentProfit { get; private set; }
        public float BaseProfit { get; private set; }
        public float LevelUpPrice { get; private set; }

        //private Balance _balance;

        // private void Start()
        // {
        //     _changeButtonActivity = new ChangeButtonActivity();
        // }

        public BusinessModel (BusinessConfig config)
        {
            CurrentLevel = config.InitialLevel;         //присваиваем значение начального уровня => значение текущего уровеня
            BaseLevelUpPrice = config.BaseLevelPrice;

            LevelUpPrice = (CurrentLevel + 1) * BaseLevelUpPrice;         //
            //todo уточнить правильность приравнивания к BaseProfitBusiness, вместо CurrentProfitBusiness
            CurrentProfit = config.BaseProfitBusiness;
            BaseProfit = config.BaseProfitBusiness;
            //_balance = new Balance();
        }

        public void UpgradeLevelButton()
        {
            if (BalanceManager.Instance.BalanceValue >= LevelUpPrice && CurrentLevel < 5)
            {
                // Debug.Log(BalanceManager.Instance.BalanceValue);
                BalanceManager.Instance.BalanceValue -= LevelUpPrice;
                CurrentLevel++;
                CurrentProfit = CurrentLevel * BaseProfit * (1 + 0 + 0);
                LevelUpPrice = (CurrentLevel + 1) * BaseLevelUpPrice;
                // Debug.Log(BalanceManager.Instance.BalanceValue);
            }
        }

        public void FirstImprovementButton()
        {
            
        }
        
        public void SecondImprovementButton()
        {
            
        }
    }
}