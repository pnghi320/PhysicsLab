using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateValue : MonoBehaviour
{
    public GameObject sensor;
    public Slider twoMassesSlider;
    public Slider hangingMassSlider;
    public Slider radiusSlider;
    public Slider pulleyRadiusSlider;


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
            gameObject.GetComponent<Acceleration>().m = twoMassesSlider.value;
            gameObject.GetComponent<Acceleration>().mw = hangingMassSlider.value;
            gameObject.GetComponent<Acceleration>().radius = radiusSlider.value;
            gameObject.GetComponent<Acceleration>().rpulley = pulleyRadiusSlider.value;
        }

    }
}
