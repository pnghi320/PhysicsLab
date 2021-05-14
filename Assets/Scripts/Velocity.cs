using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    Vector3 currentPos;
    Vector3 previousPos;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        previousPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
            currentPos = gameObject.transform.position;
            velocity = ((currentPos-previousPos)/Time.deltaTime).magnitude;
            previousPos = currentPos;
    }
    
}
