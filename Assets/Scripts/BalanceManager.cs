using System;
using config;
using TMPro;
using UnityEngine;

public class BalanceManager : MonoBehaviour
{
    private static BalanceManager instance;
    [SerializeField] private float balanceValue;
    [SerializeField] private TextMeshProUGUI _currentBalanceText;

    public static BalanceManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<BalanceManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(Balance).Name;
                    instance = obj.AddComponent<BalanceManager>();
                }
            }
            return instance;
        }
    }

    public float BalanceValue
    {
        get { return balanceValue; }
        set { balanceValue = value; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        _currentBalanceText.text = balanceValue.ToString();
    }
}