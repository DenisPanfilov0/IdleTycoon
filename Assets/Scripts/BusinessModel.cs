
namespace DefaultNamespace
{
    /// <summary>
    /// Текущая прокачка
    /// </summary>
    public class BusinessModel
    {

        public int CurrentLevel { get; private set; }
        public int LevelPrice { get; private set; }

        public BusinessModel(BusinessConfig config)
        {
            CurrentLevel = config.InitialLevel;         //присваиваем значение начального уровня => значение текущего уровеня
            LevelPrice = config.BaseLevelPrice;         //присваиваем значение базовой стоимости уровня => значение стоимости уровня
        }

        public void UpgradeLevel()
        {
            CurrentLevel++;
            //LevelPrice *= 2;
        }
    }
}