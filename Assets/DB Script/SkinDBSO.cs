using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinDBSO", menuName = "SO/SkinDB", order = int.MaxValue)]
public class SkinDB : ScriptableObject
{
    [SerializeField]
    private SkinData[] skinDB;
    private int equippedSkinNumber;
    public int skinCount
    {
        get
        {
            return skinDB.Length;
        }
    }
    public Skin Getskin(int index)
    {
        return skinDB[index].MakeCopy();
    }
    public void PurchaseSkin(int index)
    {
        skinDB[index].SetHolding();
    }
    public int GetEquipped()
    {
        return equippedSkinNumber;        
    }
    public void SetEquipped(int index)
    {        
        if (skinDB[index].GetHolding() == true)
        equippedSkinNumber = index;
    }
}
