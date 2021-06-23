using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateWeightPosition : MonoBehaviour
{
    public Slider radiusSlider;
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
        gameObject.transform.localPosition = (transform.name == "Weight1") ?
        new Vector3(0, Mathf.Clamp(-radiusSlider.value / 0.2f * 0.9f, -100f, -0.266f), 0.01499653f) :
        new Vector3(0, Mathf.Clamp(radiusSlider.value / 0.2f * 0.9f, 0.266f, 100f), 0.01499653f);
    }
}
