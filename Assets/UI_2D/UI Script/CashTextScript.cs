using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashTextScript : MonoBehaviour
{
    [SerializeField]
    private Text cashText;
    [SerializeField]
    private CashDB cashDB;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCashText();
    }

    public void UpdateCashText()
    {
        //현금 금액을 가져옵니다.
        int cashAmount = cashDB.GetCash();
        //텍스트를 업데이트합니다.
        cashText.text = cashAmount.ToString()+"$";
    }
    // Update is called once per frame
    void Update()
    {
        UpdateCashText();
    }
}
