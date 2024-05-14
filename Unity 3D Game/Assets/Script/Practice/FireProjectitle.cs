using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectitle : MonoBehaviour
{
    public Rigidbody projecttile;
    public float speed = 4;
    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody p =Instantiate(projecttile,transform.position,transform.rotation);
            p.velocity = transform.forward*speed;
        }
    }
}
