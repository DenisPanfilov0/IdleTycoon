using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ChangeButtonActivity : MonoBehaviour
    {
        [SerializeField] private GameObject ButtonOnUpgrade;
        [SerializeField] private GameObject ButtonOffUpgrade;
        [SerializeField] private GameObject ButtonFirstOnImprovement;
        [SerializeField] private GameObject ButtonFirstOffImprovement;
        [SerializeField] private GameObject ButtonSecondOnImprovement;
        [SerializeField] private GameObject ButtonSecondOffImprovement;

      
        public void ChangeButtonMaxLevel()
        {
            ButtonOnUpgrade.SetActive(false);
            ButtonOffUpgrade.SetActive(true);
        }

        public void ChangeButtonFirstEmprovement()
        {
            ButtonFirstOnImprovement.SetActive(false);
            ButtonFirstOffImprovement.SetActive(true);
        }
        
        public void ChangeButtonSecondEmprovement()
        {
            ButtonSecondOnImprovement.SetActive(false);
            ButtonSecondOffImprovement.SetActive(true);
        }
        
    }
}