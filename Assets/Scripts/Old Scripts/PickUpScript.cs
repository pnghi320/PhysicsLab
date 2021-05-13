using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    Vector3 objectPos;
    float distance;
    Ray ray;
    RaycastHit hit;

    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding;

    private void Update()
    {
        // Get the distance from the 
        distance = Vector3.Distance(item.transform.position, tempParent.transform.position);

        // If the distance of the 
        if (distance >= 1f)
            isHolding = false;

        // Resets the possition of the held object
        resetItemPos();

        // Checks if the user tries to hold or drop an item 
        if (Input.GetKeyDown(KeyCode.E) && isHolding)
        {
            drop();
            Debug.Log("Drop");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            
            ray = Camera.main.ViewportPointToRay(new Vector3(0, 0, 0));
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 100.0f))
            {
                Debug.Log("Drew Ray");
                if (hit.transform.position == transform.position)
                    hold();
            }
            hold();
            Debug.Log("hold");
        }
        // Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 100.0f, Color.red);
       
        // Loops that updates the possition of the held object
        if (isHolding)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform);
        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectPos;
        }
    }

    // Resets the item possition
    private void resetItemPos()
    {
        if (Input.GetMouseButtonDown(0) && isHolding) 
        {
            item.transform.position = tempParent.transform.position;
            item.transform.rotation = Quaternion.LookRotation(tempParent.transform.position - item.transform.position);
        }
    }

    // Updates the position of the held item
    // FIXME: Not accurate, needs another method that is accurate (RayCast)
    void hold()
    {
        if (distance <= 1f)
        {
            isHolding = true;
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }

    // Sets the flag to false to stop updating the positon of the item
    void drop()
    {
        isHolding = false;
    }
}
