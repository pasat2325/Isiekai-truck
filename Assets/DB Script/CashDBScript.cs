using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "CashDBSO", menuName = "SO/CashDB", order = int.MaxValue)]
public class CashDB : ScriptableObject
{
    [SerializeField]
    private int cash = 10000;
    
    public int GetCash()
    {
        return cash;
    }
    public void SetCash(int index)
    {
        cash = index;
    }
    
}
