using System;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class IncomeProgressBar : MonoBehaviour
    {
        
        [SerializeField] private TextMeshProUGUI _PercentProgressText;
        [SerializeField] private Slider Slider;
        private float duration = 3f;
        private float currentProgress;
        private float progressTarget = 1.0f;
        private float progressSpeed;
        private BusinessModel _model;
        private BusinessConfig _businessConfig;

        
        
        

        void Start()
        {
            _businessConfig = ScriptableObject.CreateInstance<BusinessConfig>();
            _model = new BusinessModel(_businessConfig);
            currentProgress = 0f;
            Slider.value = currentProgress;
        }
        
        public IncomeProgressBar(BusinessModel model)
        {
            _model = model;
        }

        private void Update()
        {
            _PercentProgressText.text = Mathf.RoundToInt(currentProgress * 100).ToString() + "%";
            if (currentProgress < progressTarget)
            {
                progressSpeed = 1.0f / duration;
                currentProgress += progressSpeed * Time.deltaTime;
                currentProgress = Mathf.Clamp01(currentProgress);
                Slider.value = currentProgress;
            }
            else
            {
                // currentProgress = 0f;
                // BalanceManager.Instance.BalanceValue += _model.CurrentProfit;
                Debug.Log(_model.CurrentProfit);
            }
        }
    }
}