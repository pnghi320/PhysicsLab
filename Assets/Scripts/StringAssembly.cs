using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringAssembly : MonoBehaviour
{
    public AssembleModel[] snapObjects;
    public bool modelIsReady = false;
    public GameObject whiteString;
    private float radius = 0.4f;
    public GameObject player;
    public GameObject fakeString;
    public GameObject posFakeString;
    public GameObject doublePulley;
    public bool stringAssembled = false;


    void Start()
    {
        snapObjects = FindObjectsOfType(typeof(AssembleModel)) as AssembleModel[];
    }

    // Update is called once per frame
    void Update()
    {
        int i;
        for (i = 0; i < snapObjects.Length; i++)
        {

            int ii;
            for (ii = 0; ii < snapObjects[i].snapped.Length; ii++)
            {
                if (!snapObjects[i].snapped[ii])
                {
                    break;
                }
            }
            if (ii < snapObjects[i].snapped.Length)
            {
                break;
            }
        }
        if (i == snapObjects.Length)
        {
            modelIsReady = true;
        }
        if (!stringAssembled && modelIsReady && whiteString.transform.position.x < gameObject.transform.position.x + radius && whiteString.transform.position.x > gameObject.transform.position.x - radius && (whiteString.transform.position.y < gameObject.transform.position.y + radius && whiteString.transform.position.y > gameObject.transform.position.y - radius) && (whiteString.transform.position.z < gameObject.transform.position.z + radius && whiteString.transform.position.z > gameObject.transform.position.z - radius) && (player.GetComponent<PlayerInteractions>().currentlyPickedUpObject == null) && (gameObject.GetComponent<Velocity>().velocity == 0) && (whiteString.GetComponent<Velocity>().velocity == 0))
        {
            whiteString.SetActive(false);
            fakeString.transform.position = posFakeString.transform.position;
            fakeString.transform.rotation = posFakeString.transform.rotation;
            fakeString.transform.parent = gameObject.transform;
            stringAssembled = true;
        }
    }
}
