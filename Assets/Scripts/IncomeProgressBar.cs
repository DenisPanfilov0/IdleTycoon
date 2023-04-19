using UnityEngine;

namespace DefaultNamespace
{
    public class IncomeProgressBar : MonoBehaviour
    {
        private BusinessController _businessController;
        public IncomeProgressBar(BusinessController businessController)
        {
            _businessController = businessController;
        }
        
        private void Start()
        {
            
            _businessController = FindObjectOfType<BusinessController>();
        }
    }
}