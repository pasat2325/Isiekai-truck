using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinManagerScript : MonoBehaviour
{
    [SerializeField]
    private SkinDB skinDB;
    public string selectedName;
    public SpriteRenderer selectedArtwork;
    public string selectedDescription;
    public int selectedPrice;
    public int selectedFuel;
    public int selectedSpeed;
    public bool selectedHolding;
    public int selectedOption;

    [SerializeField]
    private Button beforeButton;
    [SerializeField]
    private Button nextButton;

    void Start()
    {
        beforeButton.onClick.AddListener(BeforeOption);
        nextButton.onClick.AddListener(NextOption);

        Load();
        UpdateSkin(selectedOption);
    }
    void Update()
    {
        UpdateSkin(selectedOption);
    }

    public void NextOption()
    {
        selectedOption++;

        if(selectedOption >= skinDB.skinCount)
        {
            selectedOption = 0;
        }
        UpdateSkin(selectedOption);
    }
    public void BeforeOption()
    {
        selectedOption--;
        
        if(selectedOption < 0)
        {
            selectedOption = skinDB.skinCount - 1;
        }
        UpdateSkin(selectedOption);
    }

    private void UpdateSkin(int selectedOption)
    {

        Skin selectedSkin = skinDB.GetSkin(selectedOption);
        
        //selectedArtworkSprite = selectedSkin.artwork;
        //selectedName = selectedSkin.skinName;
        //selectedDescription.text = selectedSkin.description;
        selectedPrice = selectedSkin.price;
        selectedFuel = selectedSkin.fuel;
        selectedSpeed = selectedSkin.speed;
        selectedHolding = selectedSkin.holding;
        
    }

    private void Load()
    {
        selectedOption = skinDB.GetEquipped();
    }


}