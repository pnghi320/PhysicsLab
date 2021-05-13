using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject weight;
    private Acceleration accelerationScript;    
    public GameObject pole;
    private rotatingPole rotatingPoleScript;
    public GameObject graph;

    void Start()
    {
        accelerationScript = weight.GetComponent<Acceleration>();
        rotatingPoleScript = pole.GetComponent<rotatingPole>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            accelerationScript.Drop();
            rotatingPoleScript.Rotate();
            graph.GetComponent<ChangeLength>().CreatingLine();
        }
    }
}
