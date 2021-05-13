using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImage : MonoBehaviour
{
    // the image you want to fade, assign in inspector
    public RawImage img;
    public GameObject weight;

    void Start()
    {
        img.color = new Color(1, 1, 1, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)){
            StartCoroutine("FadeImage");
        }
        
    }
    
    IEnumerator FadeImage()
    {
        // fade from transparent to opaque
        // loop over 1 second
        for (float i = 0; i <= 2; i += 2*Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(1, 1, 1, i);
            yield return null;
        }
    }
    
}
