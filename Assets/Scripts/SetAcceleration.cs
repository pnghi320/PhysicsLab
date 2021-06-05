using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAcceleration : MonoBehaviour
{
    public GameObject weight;
    public GameObject sensor;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SetText(string str)
    {
        gameObject.GetComponent<UnityEngine.UI.Text>().text = str;
    }
    public void Show()
    {
        SetText("a = " + weight.GetComponent<Acceleration>().acceleration);
    }
}
