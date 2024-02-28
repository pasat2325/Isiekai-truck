using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SkinDBScript : MonoBehaviour
{
    [SerializeField]
    private SkinData[] skinDB;
    public int skinCount
    {
        get
        {
            return skinDB.Length;
        }
    }
    public Skin Getskin(int index)
    {
        return skinDB[index].makeCopy();
    }
    public void SetSkin(int index)
    {
        skinDB[index].setHolding();
    }

}

