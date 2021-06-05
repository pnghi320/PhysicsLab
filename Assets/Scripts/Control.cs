using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject sensor;
    public GameObject weight;
    private Acceleration accelerationScript;

    public GameObject pole;
    public GameObject virticalGear;
    public GameObject horizontalGear;

    private rotatingPole rotatingPoleScript;
    private rotatingVertGear rotatingVerticalGearScript;
    public GameObject graph;
    public GameObject accelerationText;


    void Start()
    {
        accelerationScript = weight.GetComponent<Acceleration>();
        rotatingPoleScript = pole.GetComponent<rotatingPole>();
        rotatingVerticalGearScript = virticalGear.GetComponent<rotatingVertGear>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && sensor == null)
        {
            accelerationScript.Drop();
            rotatingPoleScript.Rotate();
            rotatingVerticalGearScript.Rotate();
            graph.GetComponent<ChangeLength>().CreatingLine();
            accelerationText.GetComponent<SetAcceleration>().Show();
        }
    }
}
