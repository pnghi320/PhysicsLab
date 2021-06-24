using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateDistanceFromCenter : MonoBehaviour
{
    public Slider lengthOfRodSlider;
    public Slider distanceFromCenterSlider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void updateDistance()
    {
        distanceFromCenterSlider.maxValue = lengthOfRodSlider.value / 2f;
    }
}
