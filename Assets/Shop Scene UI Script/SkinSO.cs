using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinSO", menuName = "SO/Skin", order = int.MaxValue)]
public class Skin : ScriptableObject
{
    public string skinName;
    public string description;
    public Sprite artwork;
    public int price;
    public int fuel;
    public int durability;
    public int speed; 

    public void statPrint()
    {
        Debug.Log("fuel \t" + fuel);
        Debug.Log("durablity \t" + durability);
        Debug.Log("speed \t" + speed);
    }
}



