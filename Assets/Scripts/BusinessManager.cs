using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BusinessManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentLevelText;
    [SerializeField] private TextMeshProUGUI _currentMoneyText;
    [SerializeField] private int LevelBusiness;
    [SerializeField] private float BaseCostBusiness;
    [SerializeField] private float CurrentMoney;

    private void Start()
    {
        // LevelBusiness = 1;
        // BaseCostBusiness = 5f;
        // CurrentMoney = 10f;
        _currentLevelText.text = LevelBusiness.ToString();
        _currentMoneyText.text = CurrentMoney.ToString("C2");
    }
    
    public void BusinessLevelUp ()
    {
        if (CurrentMoney >= BaseCostBusiness && LevelBusiness < 5)
        {
            LevelBusiness++;
            _currentLevelText.text = LevelBusiness.ToString();
            CurrentMoney -= BaseCostBusiness;
            _currentMoneyText.text = CurrentMoney.ToString("C2");
        }
        

    }
    
    
}
