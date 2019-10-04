﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public Melee melee = new Melee();
    public GameObject player;

    private void Start()
    {
        melee.GenMelee();
        melee.weapon.item.durability = 100;
        melee.weapon.item.name = "Knife";
        melee.weapon.item.description = "This is a sharp kitchen knife";
        melee.weapon.damage = 12;
        melee.weapon.damageType = "sharp";
        melee.weapon.isEquiped = true;
        melee.range = 5;
        melee.weapon.item.icon = GetComponent<Texture2D>();
    }

    private void Update()
    {
        if(melee.weapon.isEquiped == true)
        {
            this.transform.position = player.transform.position;
        }
    }
}