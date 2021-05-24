using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateVerticalPully : MonoBehaviour
{
    public Rigidbody vGear;
    public float angularAcceleration;
    float angularVelocity;
    public GameObject weight;
    bool rotate = false;

    public void Rotate()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 90f));
        angularAcceleration = weight.GetComponent<Acceleration>().acceleration / 0.1f;
        angularVelocity = 0f;
        vGear = GetComponent<Rigidbody>();
        rotate = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (weight.GetComponent<Acceleration>().collided && rotate)
        {
            vGear.angularVelocity = new Vector3(0, 0, 0);
            rotate = false;
        }
        else if (rotate)
        {
            angularVelocity += angularAcceleration * Time.deltaTime;
            vGear.angularVelocity = new Vector3(0, angularVelocity, 0);
        }
    }
}
