using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SliderValueToText : MonoBehaviour
{
    public TextMeshProUGUI value;
    public Slider sliderUI;
    // Start is called before the first frame update
    void Start()
    {
        value = GetComponent<TextMeshProUGUI>();
        SetText();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetText()
    {
        value.SetText(sliderUI.value + " ");
    }
}
