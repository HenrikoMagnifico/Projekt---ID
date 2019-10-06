using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Melee
{
    public Weapons weapon = new Weapons();
    public float range;

    public Melee() { }

    public void GenMelee()
    {
        weapon.GenWeapon();
        weapon.isRanged = false;
    }
}
