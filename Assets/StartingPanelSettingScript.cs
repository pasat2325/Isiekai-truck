using System.Collections;
using System.Collections.Generic;
using DanielLochner.Assets.SimpleScrollSnap;
using UnityEngine;

public class StartingPanelSettingScript : MonoBehaviour
{
    [SerializeField] SimpleScrollSnap swipeMenu;
    [SerializeField] SkinDB skinDB;
    /*
    void () {
        int startingPanel = skinDB.GetEquipped();
        swipeMenu.GoToPanel(startingPanel);
    }*/
    
    
    void Start() {
        
        int startingPanel = skinDB.GetEquipped();
        swipeMenu.GoToPanel(startingPanel);
    
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
