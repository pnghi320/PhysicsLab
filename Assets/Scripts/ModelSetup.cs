using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ModelSetup : MonoBehaviour
{
    public bool setUp;
    public GameObject model;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!setUp && gameObject.GetComponent<StringAssembly>().stringAssembled)
        {
            // gameObject.transform.position = new Vector3(-1.87173f, -1.135151f, -2.226615f);
            // gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            // weight.transform.position = new Vector3(-1.87173f, -1.135151f, -2.226615f);
            // weight.transform.rotation = Quaternion.Euler(0, 0, 0);
            Destroy(gameObject);
            model.SetActive(true);
            setUp = true;
        }
    }
}
