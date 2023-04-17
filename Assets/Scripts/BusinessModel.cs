
//using config;

namespace DefaultNamespace
{
    /// <summary>
    /// Текущая прокачка
    /// </summary>
    public class BusinessModel
    {

        public int CurrentLevel { get; private set; }
        public float BaseLevelPrice { get; private set; }
        public float CurrentProfit { get; private set; }
        public float BaseProfit { get; private set; }
        public float LevelUpPrice { get; private set; }

        public BusinessModel (BusinessConfig config)
        {
            CurrentLevel = config.InitialLevel;         //присваиваем значение начального уровня => значение текущего уровеня
            LevelUpPrice = config.BaseLevelPrice;         //присваиваем значение базовой стоимости уровня => значение стоимости уровня
            //todo уточнить правильность приравнивания к BaseProfitBusiness, вместо CurrentProfitBusiness
            CurrentProfit = config.BaseProfitBusiness;
            BaseProfit = config.BaseProfitBusiness;
            BaseLevelPrice = config.BaseLevelPrice;
        }
        

        public void UpgradeLevel()
        {
            CurrentLevel++;
            LevelUpPrice = (CurrentLevel + 1) * BaseLevelPrice;
            CurrentProfit = CurrentLevel * BaseProfit * (1 + 0 + 0);
            

        }
    }
}