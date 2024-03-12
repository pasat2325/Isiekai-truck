using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class NewSkinPrefabScript : MonoBehaviour
{
    public SkinDB skinDB;
    public int skinNumber;
    [SerializeField]
    private Text thisName;
    [SerializeField]
    private GameObject thisArtwork;
    [SerializeField]
    private bool thisHolding;


    
    // Start is called before the first frame update
    void Start()
    {
        Skin thisSkin = skinDB.GetSkin(skinNumber);
        thisName.text = thisSkin.skinName;
        
        
        thisHolding = thisSkin.holding;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
