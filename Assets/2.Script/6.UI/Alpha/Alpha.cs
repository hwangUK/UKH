using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alpha : MonoBehaviour {

    // Use this for initialization
    Image img;    
    
    public IEnumerator Alpha_FadeOut()
    {
        gameObject.SetActive(true);
        img = gameObject.GetComponent<Image>();
        Debug.Log("ALPHA");

        img.color = new Color(0f, 0f, 0f, 0f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.1f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.2f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.3f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.4f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.5f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.6f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.7f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.8f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.9f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 1f);

    }

    public IEnumerator Alpha_FadeIn()
    {
        
        img = gameObject.GetComponent<Image>();


        img.color = new Color(0f, 0f, 0f, 1f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.9f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.8f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.7f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.6f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.5f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.4f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.3f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.2f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0.1f);
        yield return new WaitForSeconds(0.1f);
        img.color = new Color(0f, 0f, 0f, 0f);
        gameObject.SetActive(false);

    }
}
