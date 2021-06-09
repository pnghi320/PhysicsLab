using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelFader : MonoBehaviour
{
    private bool isFaded = false;
    private float count = 0f;

    public float fadeDuration = 0.4f; // 400 Milaseconds 
    public float delayBeforeFade = 2f;

    // Start is called before the first frame update
    void Start()
    {
        count = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;

        if (count > delayBeforeFade && !isFaded)
        {
            fade();
            isFaded = !isFaded;
        }

    }

    public void fade()
    {
        var canvGroup = GetComponent<CanvasGroup>();

        // Toggle end value depending on the faded state 
        StartCoroutine(FadeObject(canvGroup, canvGroup.alpha, isFaded ? 1 : 0));

    }


    // Fade Co-Routine 
    public IEnumerator FadeObject(CanvasGroup canvasGroup, float start, float end)
    {

        float counter = 0f;

        while (counter < fadeDuration)
        {

            counter += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, end, counter / fadeDuration);

            yield return null;
        }
    }
}
