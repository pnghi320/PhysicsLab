using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChangeLength : MonoBehaviour
{
    public GameObject weight;
    public float angle;
    public float length;
    public bool lineIsLongEnough = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lineIsLongEnough)
        {
            CancelInvoke("AddLength");
        }
    }
    public void CreatingLine()
    {
        lineIsLongEnough = false;
        transform.localScale = new Vector3(0f, 0.025002f, 0f);
        double acceleration = weight.GetComponent<Acceleration>().acceleration;
        angle = (float)Math.Asin(acceleration / Math.Sqrt(Math.Pow(acceleration, 2) + 1)) * (180 / (float)Math.PI);
        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.z = angle;
        transform.rotation = Quaternion.Euler(rotationVector);
        length = (float)Math.Sqrt((float)Math.Pow(acceleration, 2) + 1) * 3.149501f;
        InvokeRepeating("AddLength", 0.0f, 0.01f);
    }
    void AddLength()
    {
        transform.localScale += new Vector3(length / 100, 0f, 0f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        lineIsLongEnough = true;
    }
}
