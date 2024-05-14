using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PickUpGun : MonoBehaviour
{
    public KeyCode attachKey = KeyCode.E;
    public Rigidbody objectAttach;
    public Vector3 attachOffset =  new Vector3(0,1,0);
    public float rotationSpeed = 50f;

    public bool isAttached = false;
    private Vector3 rotationAxis;

    void Update()
    {
        if(Input.GetKeyDown(attachKey) && !isAttached)
        {
            Attach();
        }

        if(isAttached)
        {
            RotateAround();
        }
    }

    void Attach()
    {
        if(!isAttached)
        {
            objectAttach.position = transform.position + attachOffset;

            FixedJoint joint = gameObject.AddComponent<FixedJoint>();
            joint.connectedBody = objectAttach;

            isAttached = true;
        }
    
    }

    void RotateAround()
    {
        objectAttach.transform.RotateAround(transform.position,rotationAxis,rotationSpeed*Time.deltaTime);
    }
}
