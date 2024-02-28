using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashTextScript : MonoBehaviour
{
    [SerializeField]
    private Text cashText;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCashText();
    }

    public void UpdateCashText()
    {
        //현금 금액을 가져옵니다.
        int cashAmount = GetCashAmount();
        //텍스트를 업데이트합니다.
        cashText.text = cashAmount.ToString()+"$";
    }

    //현금 금액을 가져오는 함수.
    private int GetCashAmount()
    {
        //여기서 현금 금액을 가져오는 코드를 작성합니다.
        
        return 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
