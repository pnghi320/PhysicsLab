using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// Description: Script that allows the player interactions script to pick up the object that this script is added to
/// 
/// Usage: For this script to work properly and be recognized by the interaction script make sure that the object
/// this script is attached to is on the 'interactions' layer 
/// 
/// </summary>
public class PhysicsObject : MonoBehaviour
{
    public float waitOnPickup = 0.2f;
    public float breakForce = 35f;
    [HideInInspector] public bool pickedUp = false;
    [HideInInspector] public PlayerInteractions playerInteractions;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (pickedUp)
        {
            if (collision.relativeVelocity.magnitude > breakForce)
            {
                playerInteractions.BreakConnection();
            }

        }
    }

    //this is used to prevent the connection from breaking when you just picked up the object as it sometimes fires a collision with the ground or whatever it is touching
    public IEnumerator PickUp()
    {
        yield return new WaitForSecondsRealtime(waitOnPickup);
        pickedUp = true;
    }
}
