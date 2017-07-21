using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Dmg : MonoBehaviour {

    Text thisText;
    // Use this for initialization
    void Start()
    {
        thisText = this.GetComponent<Text>();
        StartCoroutine(HUD_DMG());
        
    }

    public IEnumerator HUD_DMG()
    {
        thisText.resizeTextForBestFit = true;

        thisText.rectTransform.localPosition = new Vector3(20f, -15f, 1f);
        yield return new WaitForSeconds(0.1f);
        thisText.rectTransform.localPosition = new Vector3(22f, -12f, 1f);
        yield return new WaitForSeconds(0.1f);
        thisText.rectTransform.localPosition = new Vector3(24f, -9f, 1f);
        yield return new WaitForSeconds(0.1f);
        thisText.rectTransform.localPosition = new Vector3(25f, -6f, 1f);
        yield return new WaitForSeconds(0.2f);
        thisText.rectTransform.localPosition = new Vector3(26f, -3f, 1f);
        yield return new WaitForSeconds(0.2f);

        yield return null;
    }

   
         

    // Update is called once per frame
    void LateUpdate () {
        
		
	}
}
