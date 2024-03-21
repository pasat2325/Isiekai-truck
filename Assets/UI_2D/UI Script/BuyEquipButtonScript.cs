using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class BuyEquipButtonScript : MonoBehaviour
{
    [SerializeField]
    private Button thisButton;
    [SerializeField]
    private Text BuyEquipText;
    [SerializeField]
    private SkinManagerScript selectedSkin;
    [SerializeField]
    private SkinDB skinDB;
    [SerializeField]
    private CashDB cashDB;
    [SerializeField]
    private GameObject BuyPopUpPanel;
    [SerializeField]
    private Button YesButton;
    [SerializeField]
    private Button NoButton;
    [SerializeField]
    private GameObject NoMoneyPanel;
    [SerializeField]
    private GameObject AlreadyHoldingPanel;
    [SerializeField]
    private GameObject BuySuccessPanel;

    
    // Start is called before the first frame update
    void Start()
    {
        thisButton.onClick.AddListener(()=> LeanTween.delayedCall(0.1f, BuyCheck));
        YesButton.onClick.AddListener(YesReturn);
        NoButton.onClick.AddListener(NoReturn);
        BuySuccessPanel.SetActive(false);
        BuyPopUpPanel.SetActive(false);
        NoMoneyPanel.SetActive(false);
        AlreadyHoldingPanel.SetActive(false);

    }
    void Update()
    {
        HoldingCheckAndTextReturn();
    }

    //보유중인지 확인하고 버튼 텍스를 바꾸는 함수
    private void HoldingCheckAndTextReturn()
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
    // 버튼을 누를 때 나오는 함수, 
    private void BuyCheck()
    {
        if (selectedSkin.selectedHolding == false)
        {
            if (cashDB.GetCash() < selectedSkin.selectedPrice)
            {
                NoMoneyPanel.SetActive(true);
                LeanTween.delayedCall(3.0f, () => NoMoneyPanel.SetActive(false));
            }
            else 
            {
                BuyPopUpPanel.SetActive(true);
                
            }
        }
        else 
        {
            if (skinDB.GetEquipped() != selectedSkin.selectedOption)
            {
                skinDB.SetEquipped(selectedSkin.selectedOption);
            }
        }

    }
    // 패널 활성화 비활성화 하는 함수, true 입력시 활성화, false 입력 시 비활성화
    private void FadeIn (GameObject Panel)
    {
        LeanTween.alpha(Panel, 1f, 0.3f);
    }
    private void FadeOut (GameObject Panel)
    {
        LeanTween.alpha(Panel, 0f, 0.3f);
    }
    // No버튼 누르면 실행, 패널을 비활성화
    private void NoReturn()
    {
        BuyPopUpPanel.SetActive(false);
    }
    // Yes버튼 누르면 실행, cashDB에서 가격 뺀 후 skinDB의 현재 선택한 스킨 보유중으로 바꾸고 성공 패널 띄움
    private void YesReturn()
    {
        int cashNow = cashDB.GetCash();
        int price = selectedSkin.selectedPrice;
        if (selectedSkin.selectedHolding == true)
        {
            BuyPopUpPanel.SetActive(false);
            AlreadyHoldingPanel.SetActive(true);
                LeanTween.delayedCall(1.5f, ()=> AlreadyHoldingPanel.SetActive(false));
        }
        else
        {
            if (cashNow < price)
            {
                NoMoneyPanel.SetActive(true);
                LeanTween.delayedCall(1.5f, ()=> NoMoneyPanel.SetActive(false));
            }
            else 
            {
                cashDB.SetCash(cashNow-price);
                skinDB.PurchaseSkin(selectedSkin.selectedOption);
                BuyPopUpPanel.SetActive(false);
                BuySuccessPanel.SetActive(true);
                LeanTween.delayedCall(1.5f, ()=> BuySuccessPanel.SetActive(false));
            }
        }
    }
}
