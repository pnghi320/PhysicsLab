using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartBUpdateValue : MonoBehaviour
{
    public GameObject sensor;
    public Slider massOfRodSlider;
    public Slider massOfWeightSlider;
    public Slider lengthOfRodSlider;
    public Slider distanceFromCenterSlider;
    public Slider rpulleySlider;

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
            gameObject.GetComponent<PartBAcceleration>().massOfRod = massOfRodSlider.value;
            gameObject.GetComponent<PartBAcceleration>().massOfWeight = massOfWeightSlider.value;
            gameObject.GetComponent<PartBAcceleration>().lengthOfRod = lengthOfRodSlider.value;
            gameObject.GetComponent<PartBAcceleration>().distanceFromCenter = distanceFromCenterSlider.value;
            gameObject.GetComponent<PartBAcceleration>().rpulley = rpulleySlider.value;
        }

    }
}
