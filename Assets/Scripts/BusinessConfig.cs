using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Конфиг
/// </summary>
[CreateAssetMenu(menuName = nameof(BusinessConfig))]
public class BusinessConfig : ScriptableObject
{
    public int InitialLevel => _initialLevel;       //начальный уровень =
    public int BaseLevelPrice => _baseLevelPrice;       //цена базового уровня =
        
    [SerializeField] private int _initialLevel = 1;
    [SerializeField] private int _baseLevelPrice = 100;
}
