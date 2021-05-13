using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    public float mw;
    public float m;
    public float rpulley;
    public float radius;
    public float acceleration;
    float forwardVelocity;
    public Rigidbody rb;
    public Collider coll;
    public bool collided = false;
    // Start is called before the first frame update
    void Awake()
    {
        
    }
    void Update () 
    {
        if (!collided){
            forwardVelocity += acceleration * Time.deltaTime;
            rb.velocity = transform.forward * forwardVelocity;
        }
    }
    public void Drop(){
        collided = false;
        transform.position = new Vector3(2.3067f,-0.813f,-2.446f);
        transform.rotation = Quaternion.Euler(new Vector3(90f,0f,0f));
        acceleration = 9.8f/(((m*Mathf.Pow(radius, 2)+0.000265f)/(mw*Mathf.Pow(rpulley, 2)))+1);
        forwardVelocity = 0f;
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
    }
    void OnCollisionEnter(Collision collide)
    {    
        if(collide.gameObject.name == "Table1")        
        {
            collided = true;
            forwardVelocity = 0f;
            acceleration = 0f;
        }        
    }
}
