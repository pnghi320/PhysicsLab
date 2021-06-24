using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartBControl : MonoBehaviour
{
    public GameObject sensor;
    public GameObject weight;
    private PartBAcceleration accelerationScript;

    // public GameObject pole;
    public GameObject bar;

    public GameObject virticalGear;
    public GameObject horizontalGear;

    // private rotatingPole rotatingPoleScript;
    private rotatingBar rotatingBarScript;

    private PartBrotatingVertGear rotatingVerticalGearScript;
    public GameObject graph;
    public GameObject accelerationText;


    void Start()
    {
        accelerationScript = weight.GetComponent<PartBAcceleration>();
        // rotatingPoleScript = pole.GetComponent<rotatingPole>();
        rotatingBarScript = bar.GetComponent<rotatingBar>();
        rotatingVerticalGearScript = virticalGear.GetComponent<PartBrotatingVertGear>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && sensor == null)
        {
            accelerationScript.Drop();
            // rotatingPoleScript.Rotate();
            rotatingBarScript.Rotate();
            rotatingVerticalGearScript.Rotate();
            graph.GetComponent<PartBChangeLength>().CreatingLine();
            accelerationText.GetComponent<PartBSetAcceleration>().Show();
        }
    }
}
