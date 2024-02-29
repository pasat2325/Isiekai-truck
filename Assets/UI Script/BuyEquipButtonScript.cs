using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyEquipButtonScript : MonoBehaviour
{
    [SerializeField]
    private Button BuyEquipButton;
    [SerializeField]
    private Text BuyEquipText;
    [SerializeField]
    private SkinManagerScript selectedSkin;
    [SerializeField]
    private SkinDB skinDB;
    // Start is called before the first frame update
    void Start()
    {
        HoldingCheck();
    }

    public void Onclick()
    {
        Debug.Log("hi");
    }
    //보유중인지 확인하는 함수
    private void HoldingCheck()
    {
        if (selectedSkin.selectedHolding == false)
        {
            BuyEquipText.text = "Buy";
        }
        else 
        {
            if (skinDB.GetEquipped() == selectedSkin.selectedOption)
            {
                BuyEquipText.text = "Equipping..";
            }
            else 
            {
                BuyEquipText.text = "Equip";
            }
        }
    }
}
