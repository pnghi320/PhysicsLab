using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelSetup : MonoBehaviour
{
    public bool setUp;
    public GameObject model;
    public GameObject hangingWeight;
    public Slider radiusSlider;
    public Slider hangingMassSlider;
    public Slider twoMassesSlider;
    public Slider pulleyRadiusSlider;


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
            if (gameObject.transform.Find("Weight2") != null)
            {
                hangingWeight.GetComponent<Acceleration>().mw = 0.075f;
            }
            else
            {
                hangingWeight.GetComponent<Acceleration>().mw = 0.15f;
            }
            radiusSlider.value = hangingWeight.GetComponent<Acceleration>().radius;
            hangingMassSlider.value = hangingWeight.GetComponent<Acceleration>().mw;
            twoMassesSlider.value = hangingWeight.GetComponent<Acceleration>().m;
            pulleyRadiusSlider.value = hangingWeight.GetComponent<Acceleration>().rpulley;
            Destroy(gameObject);
            setUp = true;
        }
    }
}
