using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public float pickuprange=2f;
    public KeyCode pickupKey=KeyCode.F;

    private GameObject currentItem= null;
    
    void Update()
    {
        DectecItem();
        if(currentItem!=null && Input.GetKeyDown(pickupKey))
        {
            PickUp(currentItem);
        }
        
    }

    void DectecItem()
    {

    }

    void PickUp(GameObject item)
    {

    }
}
