using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinStatDisplayScript : MonoBehaviour
{
    [SerializeField]
    private SkinManagerScript skinData;
    [SerializeField]
    private Text skinFuel;
    [SerializeField]
    private Text skinDurability;
    [SerializeField]
    private Text skinSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        skinFuel.text = skinData.selectedFuel.ToString();
        skinDurability.text =  skinData.selectedFuel.ToString();
        skinSpeed.text =  skinData.selectedSpeed.ToString();
    }
}
