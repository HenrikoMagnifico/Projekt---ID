using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items 
{
    public int durability;
    public bool hasDurability;
    public bool isUsable;
    public int amount;
    public int maxAmount;
    public int ID;
    public bool isKey;
    public bool canSell;
    public bool isWeapon;
    public string description;
    public string name;
    public Texture2D icon;

    public Items() { }

    public void DisplayInfo(string name, string desc)
    {
        //when hovering item show this
    }
}
