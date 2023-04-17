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
        [SerializeField] private Button ButtonFirstOnImprovement;
        [SerializeField] private Button ButtonFirstOffImprovement;
        [SerializeField] private Button ButtonSecondOnImprovement;
        [SerializeField] private Button ButtonSecondOffImprovement;

      
        public void ChangeButtonMaxLevel()
        {
            ButtonOnUpgrade.SetActive(false);
            ButtonOffUpgrade.SetActive(true);
        }
    }
}