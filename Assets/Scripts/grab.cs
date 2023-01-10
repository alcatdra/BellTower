using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour
{
    public GameObject rope;

    public GameObject controller;

    public float reachDistance = 1f;

    private FixedJoint joint;

    void Update()
    {
        if (Input.GetButtonDown("Grab"))
        {
            RaycastHit hit;
            if (Physics.Raycast(controller.transform.position, controller.transform.forward, out hit, reachDistance))
            {
                if (hit.collider.gameObject == rope)
                {
                    joint = controller.AddComponent<FixedJoint>();
                    joint.connectedBody = rope.GetComponent<Rigidbody>();
                }
            }
        }

        if (Input.GetButtonUp("Grab"))
        {
            if (joint != null)
            {
                Destroy(joint);
                joint = null;
            }
        }
    }
}