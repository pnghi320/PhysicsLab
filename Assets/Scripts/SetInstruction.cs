using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInstruction : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sensor;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sensor != null)
        {
            SetText("Aim and left click to pick up and drop down an object");
        }
        else if (sensor == null)
        {
            SetText("Hit enter to run trails and left click to change variables");
        }
    }

    void SetText(string str)
    {
        gameObject.GetComponent<UnityEngine.UI.Text>().text = str;
    }
}
