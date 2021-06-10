using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateValue : MonoBehaviour
{
    public GameObject sensor;
    public Slider SliderTwoMasses;
    public Slider SliderHangingMass;
    public Slider SliderRadius;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateScriptValue()
    {
        if (sensor == null)
        {
            gameObject.GetComponent<Acceleration>().m = SliderTwoMasses.value;
            gameObject.GetComponent<Acceleration>().mw = SliderHangingMass.value;
            gameObject.GetComponent<Acceleration>().radius = SliderRadius.value;
        }

    }
}
