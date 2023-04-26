/// <summary>
/// Model. Модель бизнеса, текущая прокачка и другие свойства описывающие данную модель
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
        CurrentLevel = config.InitialLevel;
        BaseLevelUpPrice = config.BaseLevelPrice;
        Delay = config.Delay;
        FirstImprovement = config.FirstImprovement;
        SecondImprovement = config.SecondImprovement;
        LevelUpPrice = (CurrentLevel + 1) * BaseLevelUpPrice;
        CurrentProfit = config.BaseProfitBusiness;
        BaseProfit = config.BaseProfitBusiness;
        BusinessName = config.BusinessName;
    }

    public void UpgradeLevelButton()
    {
        if (Balance.Instance.BalanceValue >= LevelUpPrice && CurrentLevel < 5)
        {
            Balance.Instance.BalanceValue -= LevelUpPrice;
            CurrentLevel++;
            CurrentProfit += CurrentLevel * BaseProfit * (1 + 0 + 0);
            LevelUpPrice = (CurrentLevel + 1) * BaseLevelUpPrice;
        }
    }

    public void FirstImprovementButton()
    {
        if (Balance.Instance.BalanceValue >= BaseLevelUpPrice * 10)
        {
            CurrentProfit += FirstImprovement;
            Balance.Instance.BalanceValue -= BaseLevelUpPrice * 10;
        }
    }
        
    public void SecondImprovementButton()
    {
        if (Balance.Instance.BalanceValue >= BaseLevelUpPrice * 20)
        {
            CurrentProfit *= (SecondImprovement / 100) + 1;
            Balance.Instance.BalanceValue -= BaseLevelUpPrice * 20;
        }
    }
}