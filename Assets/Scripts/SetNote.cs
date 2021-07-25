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
            /*
            if (hit.transform.gameObject.tag == "massLabel"){
                gameObject.GetComponent<UnityEngine.UI.Text>().text = hit.transform.gameObject.GetComponent<Rigidbody>().mass.ToString()+" kg";
            }
            else{
                gameObject.GetComponent<UnityEngine.UI.Text>().text = "";
            }
            */

            switch (hit.transform.gameObject.tag)
            {
                case "massLabel":
                    gameObject.GetComponent<UnityEngine.UI.Text>().text = hit.transform.gameObject.GetComponent<Rigidbody>().mass.ToString() + " kg";
                    Debug.Log("This Works");
                    break;
                case "Rod":
                    gameObject.GetComponent<UnityEngine.UI.Text>().text = "Rod that holds two weights at its ends. Attached to the top of the Motion Sensor";
                    Debug.Log("The Pole");
                    break;
                case "Bar":
                    gameObject.GetComponent<UnityEngine.UI.Text>().text = "Bar Attached to the top of the Montion Sensor";
                    break;
                case "MotionSensor":
                    gameObject.GetComponent<UnityEngine.UI.Text>().text = "Detects the motion of the items attached to it";
                    break;
                case "Clamp":
                    gameObject.GetComponent<UnityEngine.UI.Text>().text = "Holds the Super-Pully an its attached to the Motion Sensor";
                    break;
                case "Thread":
                    gameObject.GetComponent<UnityEngine.UI.Text>().text = "White string that holds mass of the super pully. Is added last";
                    break;
                case "Base":
                    gameObject.GetComponent<UnityEngine.UI.Text>().text = "Holds the rest of the Rotary Motion system";
                    break;
                case "SupportRod":
                    gameObject.GetComponent<UnityEngine.UI.Text>().text = "Is added to the base with or without the Motion Sensor";
                    break;
                case "ThreeStep":
                    gameObject.GetComponent<UnityEngine.UI.Text>().text = "Spins with the Rod on top of the Motion sensor. Added before the rod";
                    break;
                case "SuperPulley":
                    gameObject.GetComponent<UnityEngine.UI.Text>().text = "Is added to the clamp after its added to the Motion Sensor";
                    break;
                default:
                    gameObject.GetComponent<UnityEngine.UI.Text>().text = "";
                    break;
            }
        }
        
    }
}
