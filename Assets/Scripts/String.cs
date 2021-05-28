using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String : MonoBehaviour
{
    public GameObject weight;
    public GameObject thread;
    public float length;

    public Rigidbody cylinderPrefab; //assumed to be 1m x 1m x 2m default unity cylinder to make calculations easy

    // Start is called before the first frame update
    void Start()
    {
    }

    void CreateCylinderBetweenPoints(Vector3 start, Vector3 end, float width)
    {
        var offset = end - start;
        var scale = new Vector3(width, offset.magnitude / 2.0f, width);
        var position = start + (offset / 2.0f);
        var cylinder = Instantiate(cylinderPrefab, position, Quaternion.identity);
        cylinder.transform.up = offset;
        cylinder.transform.localScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        length = Vector3.Distance(weight.transform.position, thread.transform.position);
        Debug.Log(length);
        Vector3 scale = gameObject.transform.localScale;
        scale.y = 9.8f * length;
        gameObject.transform.localScale = scale;
    }
}