using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    Actor actor = new Actor();
    List<string> quest;
    List<bool> questDone;
    List<int> reputation;
    public float speed;
    public List<GameObject> inventory;
    Vector2 movement;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        actor.name = "Fisher";
        actor.ID = 1000;
        actor.resistance = 1;
        actor.speed = speed;
        actor.canMove = true;
        actor.canInteract = true;
        actor.attack = 10;
        actor.attacking = false;
        actor.attackType = "";
        actor.Inventory = inventory;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
