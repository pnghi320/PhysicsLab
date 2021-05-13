using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssembleModel : MonoBehaviour
{
    public bool[] snapped;
    public GameObject player;
    public GameObject[] obj;
    public GameObject[] pt;
    public Vector3[] objRotation;
    public Vector3 gameObjectRotation;
    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0 ; i < obj.Length; i++)
        {
            snapped[i] = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < obj.Length; i++){
            if (snapped[i] == false && (obj[i].transform.position.x < gameObject.transform.position.x + radius && obj[i].transform.position.x > gameObject.transform.position.x - radius) && (obj[i].transform.position.y < gameObject.transform.position.y + radius && obj[i].transform.position.y > gameObject.transform.position.y - radius) && (obj[i].transform.position.z < gameObject.transform.position.z + radius && obj[i].transform.position.z > gameObject.transform.position.z - radius) && (player.GetComponent<PlayerInteractions>().currentlyPickedUpObject == null) && (gameObject.GetComponent<Rigidbody>().velocity.magnitude == 0) && (obj[i].GetComponent<Rigidbody>().velocity.magnitude == 0)){
                snapObject(obj[i], pt[i], objRotation[i]);
                snapped[i] = true;
            }
        }
        
    }
    public void snapObject(GameObject obj, GameObject pt, Vector3 objRotation){
        obj.transform.rotation = Quaternion.Euler(objRotation);
        gameObject.transform.rotation = Quaternion.Euler(gameObjectRotation);
        obj.GetComponent<BoxCollider>().enabled = false;
        Destroy (obj.GetComponent<Rigidbody>());
        Destroy(obj.GetComponent<PhysicsObject>());
        obj.transform.position = pt.transform.position;
        obj.transform.rotation = pt.transform.rotation;
        obj.transform.parent = gameObject.transform;
    }
}
