using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Actor
{
    public string name;
    public int ID;
    public int hp;
    public float speed;
    public float attack;
    public string attackType;
    public bool attacking;
    public bool canInteract;
    public bool canMove;
    public float resistance;
    public List<GameObject> Inventory;
    public Animation anim;

    public Actor()
    {

    }

    public int TakeDamage(int hp, float attack, float res)
    {
        attack /= res;
        hp -= (int)attack;
        return hp;
    }

    public float Attack(float attack, string effect, float duration, int hp)
    {
        if(effect != "")
        {
            AddEffect(effect, duration, hp);
        }

        return attack;
    }

    public void AddEffect(string name, float duration, int hp)
    {
        //DO EFFECT
        Debug.Log("Effect: " + name);
    }
}
