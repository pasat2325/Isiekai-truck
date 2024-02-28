using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButtonScript : MonoBehaviour
{
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(Onclick);
    }

    public void Onclick()
    {
        Debug.Log("hi");
    }
}
