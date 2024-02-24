using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SkinStatDisplayScript : MonoBehaviour
{
    [SerializeField]
    private Skin selectedSkin;
    
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
        skinFuel.text =  new string('#',selectedSkin.fuel);
        skinDurability.text =  new string('#',selectedSkin.durability);
        skinSpeed.text =  new string('#',selectedSkin.speed);
    }
}
