using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.UI;

public class NewSkinPrefabScript : MonoBehaviour
{
    public SkinDB skinDB;
    public int skinNumber;

    [SerializeField]
    private GameObject thisArtwork;

    [SerializeField]
    private bool thisHolding;
    
    [SerializeField]
    private GameObject parent;

    private bool skinPurchase;

    [SerializeField]
    private GameObject lockImage;

    public void skinNumberChange(int i)
    {
        skinNumber = i;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Skin thisSkin = skinDB.GetSkin(skinNumber);
        
        thisArtwork = thisSkin.artwork;
        float xscale = 30f;
        float yscale = 30f;
        float zscale = 30f;
        thisArtwork.transform.localScale = new Vector3(xscale, yscale, zscale);
        Instantiate(thisArtwork, parent.transform);
        thisHolding = thisSkin.holding;
        if (thisHolding == true)
        {
            DeleteLock();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Skin thisSkin = skinDB.GetSkin(skinNumber);
        skinPurchase = thisSkin.holding;
        if (skinPurchase == true && thisHolding == false) 
        {
            thisHolding = true;
            DeleteLock();
        }
    }

    void DeleteLock()
    {
        lockImage.SetActive(false);
    }
}
