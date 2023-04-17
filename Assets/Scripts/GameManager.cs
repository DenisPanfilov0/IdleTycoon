using config;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Balance _balance;
        [SerializeField] private TextMeshProUGUI _currentBalanceText;


        private void Start()
        {
            _balance = new Balance();
        }

        private void Update()
        {
            _currentBalanceText.text = _balance.BalanceValue.ToString();
        }
    }
}