using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightManager : MonoBehaviour
{
    public AssembleModel snapObjects;
    private bool oneWeightIn = false;
    // Start is called before the first frame update
    void Start()
    {
        snapObjects = GetComponent<AssembleModel>();
    }

    // Update is called once per frame
    void Update()
    {
        if (snapObjects && !oneWeightIn)
        {
            if (gameObject.GetComponent<AssembleModel>().snapped[0] || gameObject.GetComponent<AssembleModel>().snapped[0])
            {
                gameObject.GetComponent<AssembleModel>().snapped[2] = true;
                gameObject.GetComponent<AssembleModel>().snapped[3] = true;
                oneWeightIn = true;
            }
            else if (gameObject.GetComponent<AssembleModel>().snapped[2] || gameObject.GetComponent<AssembleModel>().snapped[3])
            {
                gameObject.GetComponent<AssembleModel>().snapped[0] = true;
                gameObject.GetComponent<AssembleModel>().snapped[1] = true;
                oneWeightIn = true;
            }
        }
    }
}
