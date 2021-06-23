using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartBModelSetup : MonoBehaviour
{
    public bool setUp;
    public GameObject model;
    public GameObject hangingWeight;
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
        if (!setUp && gameObject.GetComponent<StringAssembly>().stringAssembled)
        {
            model.SetActive(true);
            massOfRodSlider.value = hangingWeight.GetComponent<PartBAcceleration>().massOfRod;
            massOfWeightSlider.value = hangingWeight.GetComponent<PartBAcceleration>().massOfWeight;
            lengthOfRodSlider.value = hangingWeight.GetComponent<PartBAcceleration>().lengthOfRod;
            distanceFromCenterSlider.value = hangingWeight.GetComponent<PartBAcceleration>().distanceFromCenter;
            rpulleySlider.value = hangingWeight.GetComponent<PartBAcceleration>().rpulley;
            Destroy(gameObject);
            setUp = true;
        }
    }
}
