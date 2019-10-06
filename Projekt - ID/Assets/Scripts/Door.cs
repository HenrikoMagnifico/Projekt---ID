using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool Horizontal, Rotated;
    public GameObject player;
    Rigidbody2D rb;
    Vector2 pos;
    Dialouge dia;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        pos = this.transform.position;
    }

    private void Update()
    {
        this.transform.position = pos;
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Horizontal)
            {
                if(player.transform.position.y > this.transform.position.y && Rotated == false)
                {
                    rb.freezeRotation = false;
                    rb.AddForce(new Vector2(0,-1));
                    dia = new Dialouge("Door open");
                    Rotated = true;
                }
                /*if (Rotated == true)
                {
                    rb.freezeRotation = true;
                    this.transform.rotation = Quaternion.Euler(0, 0, 0);
                }*/
            }
        }
    }
}
