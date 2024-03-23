using System.Collections;
using System.Collections.Generic;
using DanielLochner.Assets.SimpleScrollSnap;
using UnityEngine;

public class StartingPanelSettingScript : MonoBehaviour
{
    [SerializeField] SimpleScrollSnap swipeMenu;
    [SerializeField] SkinDB skinDB;
    void Start()
    {
        int startingPanel = skinDB.GetEquipped();
        swipeMenu.StartingPanel = startingPanel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
