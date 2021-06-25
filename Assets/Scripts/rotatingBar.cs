using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingBar : MonoBehaviour
{
    public Rigidbody bar;
    public float angularAcceleration;
    float angularVelocity;
    public GameObject weight;
    bool rotate = false;

    public void Rotate()
    {
        // transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        angularAcceleration = weight.GetComponent<PartBAcceleration>().acceleration / 0.1f;
        angularVelocity = 0f;
        bar = GetComponent<Rigidbody>();
        rotate = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (weight.GetComponent<PartBAcceleration>().collided && rotate)
        {
            bar.angularVelocity = new Vector3(0, 0, 0);
            rotate = false;
        }
        else if (rotate)
        {
            angularVelocity += angularAcceleration * Time.deltaTime;
            bar.angularVelocity = new Vector3(0, angularVelocity, 0);
        }
    }

}
