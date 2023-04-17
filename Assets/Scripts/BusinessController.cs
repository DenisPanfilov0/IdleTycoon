using UnityEngine;

namespace DefaultNamespace
{
    /// <summary>
    /// Контроллер - пересылает нажатие кнопок или другие события в модель
    /// </summary>
    public class BusinessController : MonoBehaviour
    {
        public BusinessModel _model;
        public BusinessController(BusinessConfig config)
        {
            _model = new BusinessModel(config);
            Debug.Log("abc");
        }

        public void OnUpgradeButtonClick()
        {
            //_model.UpgradeLevel();
            Debug.Log(_model.CurrentLevel);
        }
    }
}