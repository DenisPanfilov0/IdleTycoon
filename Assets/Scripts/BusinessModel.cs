using System;
//using config;
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
        public float FirstImprovement { get; private set; }
        public float SecondImprovement { get; private set; }
        public float Delay { get; private set; }
        public string BusinessName { get; private set; }

        public BusinessModel (BusinessConfig config)
        {
            CurrentLevel = config.InitialLevel;         //присваиваем значение начального уровня => значение текущего уровеня
            BaseLevelUpPrice = config.BaseLevelPrice;
            Delay = config.Delay;
            FirstImprovement = config.FirstImprovement;
            SecondImprovement = config.SecondImprovement;
            LevelUpPrice = (CurrentLevel + 1) * BaseLevelUpPrice;         


            //todo уточнить правильность приравнивания к BaseProfitBusiness, вместо CurrentProfitBusiness
            CurrentProfit = config.BaseProfitBusiness;
            BaseProfit = config.BaseProfitBusiness;
            BusinessName = config.BusinessName;
        }

        public void UpgradeLevelButton()
        {
            if (BalanceManager.Instance.BalanceValue >= LevelUpPrice && CurrentLevel < 5)
            {

                BalanceManager.Instance.BalanceValue -= LevelUpPrice;
                CurrentLevel++;
                CurrentProfit = CurrentLevel * BaseProfit * (1 + 0 + 0);
                LevelUpPrice = (CurrentLevel + 1) * BaseLevelUpPrice;

            }
        }

        public void FirstImprovementButton()
        {
            if (BalanceManager.Instance.BalanceValue >= BaseLevelUpPrice * 10)
            {
                CurrentProfit += FirstImprovement;
                BalanceManager.Instance.BalanceValue -= BaseLevelUpPrice * 10;
            }
        }
        
        public void SecondImprovementButton()
        {
            if (BalanceManager.Instance.BalanceValue >= BaseLevelUpPrice * 20)
            {
                CurrentProfit *= (SecondImprovement / 100) + 1;
                BalanceManager.Instance.BalanceValue -= BaseLevelUpPrice * 20;
            }
        }
    }
}