using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateBarPosition : MonoBehaviour
{
    public Slider distanceFromCenterSlider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdatePosition()
    {
        float ratio = distanceFromCenterSlider.value / distanceFromCenterSlider.maxValue;
        gameObject.transform.localPosition = new Vector3(ratio * 0.475f, 0, 0);
    }
}
