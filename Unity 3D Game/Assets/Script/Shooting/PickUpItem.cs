using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public float pickupRange=2.0f;
    public KeyCode pickupkey=KeyCode.F;

    private GameObject currentItem = null;

    void Update()
    {
        DetecItem();

        if(currentItem!= null && Input.GetKeyDown(pickupkey))
        {
            PickUP(currentItem);   
        }
    }

    void DetecItem()
    {
        currentItem=null;

        Collider[] hitColliders = Physics.OverlapSphere(transform.position,pickupRange);
        foreach( var hitCollider in hitColliders)
        {
            if(hitCollider.CompareTag("PickupItem"))
            {
                currentItem = hitCollider.gameObject;
                break;
            }
        }
    }

    void PickUP(GameObject item)
    {
        Debug.Log("撿取了"+item.name);
        item.SetActive(false);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position,pickupRange);
    }
}
