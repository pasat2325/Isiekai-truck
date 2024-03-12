using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SkinSO", menuName = "SO/SkinData", order = int.MaxValue)]
public class SkinData : ScriptableObject
{
    [SerializeField]
    protected string skinName;
    [SerializeField]
    protected string description;  
    [SerializeField] 
    protected Mesh artwork;  
    [SerializeField]
    protected int price;
    [SerializeField]   
    protected int fuel;
    [SerializeField]  
    protected int durability;
    [SerializeField] 
    protected int speed;
    [SerializeField]   
    protected bool holding;
    
    public bool GetHolding()
    {
        return holding; 
    }    
    public void SetHolding()
    {
        holding = true;
    }
    public Skin MakeCopy()
    {   
        Skin copy = new Skin (skinName,description, artwork, price, fuel, durability, speed, holding);
        return copy;
    }

    
}
public class Skin: SkinData
{
    public new string skinName ;
    public new string description ;
    public new GameObject artwork ;
    public new int price;
    public new int fuel;
    public new int durability;
    public new int speed; 
    public new bool holding;
    
    public Skin(string skinName, string description, GameObject artwork, int price, int fuel, int durability, int speed, bool holding)
    {
        this.skinName = skinName;
        this.description = description;
        this.artwork = artwork;
        this.price = price;
        this.fuel = fuel;
        this.durability = durability;
        this.speed = speed;
        this.holding = holding;
    }
    
}

