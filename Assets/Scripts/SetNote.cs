using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetNote : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<UnityEngine.UI.Text>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ViewportPointToRay(new Vector3(0, 0, 0));
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 100.0f)){
            if (hit.transform.gameObject.tag == "massLabel"){
                gameObject.GetComponent<UnityEngine.UI.Text>().text = hit.transform.gameObject.GetComponent<Rigidbody>().mass.ToString()+" kg";
            }
            else{
                gameObject.GetComponent<UnityEngine.UI.Text>().text = "";
            }
        }
        
    }
}
