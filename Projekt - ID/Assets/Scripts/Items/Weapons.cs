﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons
{
    public Items item = new Items();
    public int damage;
    public bool isRanged;
    public string damageType;
    public bool isEquiped;

    public void GenWeapon()
    {
        item.isKey = false;
        item.isUsable = true;
        item.maxAmount = 1;
        item.amount = 1;
        item.canSell = false;
    }
}
