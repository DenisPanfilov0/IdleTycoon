using TMPro;
using UnityEngine;

public class Balance : MonoBehaviour
{
    private static Balance instance;
    [SerializeField] private float balanceValue;
    [SerializeField] private TextMeshProUGUI _currentBalanceText;

    public static Balance Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Balance>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(Balance).Name;
                    instance = obj.AddComponent<Balance>();
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