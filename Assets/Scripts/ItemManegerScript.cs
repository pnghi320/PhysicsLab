using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManegerScript : MonoBehaviour
{

    public List<GameObject> items;
    public float catchThreshold  = -10f;

    private Vector3[] diffaultPositions;
    private bool isBusy = false;
    

    // Start is called before the first frame update
    void Start()
    {
        // Checks that items are added to the list
        if(items.Count == 0)
        {
            Debug.Log("No Items from sceen added");
            return;
        }

        // Saves the positions where each object started at
        diffaultPositions = new Vector3[items.Count];
        int i = 0;
        foreach (GameObject gb in items)
        {
            diffaultPositions[i] = gb.transform.position;
            i++;
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        // If statment that calles the itemCheck function once it is done iterating through each object 
        if (!isBusy)
        {
            isBusy = true;
            itemCheck();
        }
    }

    private void itemCheck()
    {

        // Resets the positon of an object if it is out of bounds
        int i = 0;
        foreach (GameObject gb in items)
        {      
            if (gb.transform.position.y < catchThreshold)
            {
                Debug.Log("Object Fell out of bounds: " + gb.name + " - Initial Pos is: " + diffaultPositions[i] + " - index: " + i);
                items[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
                gb.transform.position = diffaultPositions[i];
            }
            i++;
        }
        isBusy = false;
    }
}
