using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartBAcceleration : MonoBehaviour
{
    public Vector3 weightPos;
    public float massOfRod;
    public float massOfWeight;
    public float lengthOfRod;
    public float distanceFromCenter;
    public float rpulley;
    public float acceleration;
    float forwardVelocity;
    public Rigidbody rb;
    public Collider coll;
    public bool collided = false;
    // Start is called before the first frame update
    void Start()
    {
        weightPos = gameObject.transform.position;
    }
    void Update()
    {
        if (!collided)
        {
            forwardVelocity += acceleration * Time.deltaTime;
            rb.velocity = transform.forward * forwardVelocity;
        }

    }
    public void Drop()
    {
        collided = false;
        transform.position = weightPos;
        transform.rotation = Quaternion.Euler(new Vector3(90f, 0f, 0f));
        acceleration = 9.8f / ((((massOfRod/12f)*(Mathf.Pow(lengthOfRod,2)+12f*(Mathf.Pow(distanceFromCenter,2))))/(massOfWeight*Mathf.Pow(rpulley,2)))+1f);
        forwardVelocity = 0f;
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
    }
    void OnCollisionEnter(Collision collide)
    {
        if (collide.gameObject.name == "Table2")
        {
            collided = true;
            forwardVelocity = 0f;
            acceleration = 0f;
        }
    }
}
