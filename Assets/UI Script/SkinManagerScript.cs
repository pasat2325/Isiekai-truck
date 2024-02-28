using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinManagerScript : MonoBehaviour
{
    private SkinDBScript SkinDB;
    public string selectedName;
    public SpriteRenderer selectedArtwork;
    public string selectedDescription;
    public int selectedPrice;
    public int selectedFuel;
    public int selectedSpeed;
    public bool selectedHolding;
    private int selectedOption = 0;
    void Start()
    {   
        SkinDB = transform.GetComponent<SkinDBScript>();
        if (PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        UpdateSkin(selectedOption);
    }

    public void NextOption()
    {
        selectedOption++;

        if(selectedOption >= SkinDB.skinCount)
        {
            selectedOption = 0;
        }
        UpdateSkin(selectedOption);
        Save();
    }
    public void BeforeOption()
    {
        selectedOption--;
        
        if(selectedOption < 0)
        {
            selectedOption = SkinDB.skinCount - 1;
        }
        UpdateSkin(selectedOption);
        Save();
    }

    private void UpdateSkin(int selectedOption)
    {

        Skin selectedSkin = SkinDB.Getskin(selectedOption);
        
        //selectedArtworkSprite = selectedSkin.artwork;
        //selectedName = selectedSkin.skinName;
        //selectedDescription.text = selectedSkin.description;
        //selectedPrice.text = selectedSkin.price.ToString();
        selectedFuel = selectedSkin.fuel;
        selectedSpeed = selectedSkin.speed;
        //selectedHolding = selectedSkin.holding;
        
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption",selectedOption);
    }

    public static implicit operator Text(SkinManagerScript v)
    {
        throw new NotImplementedException();
    }


}