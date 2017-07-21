using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD_Add_JustText : MonoBehaviour {

    public Camera UI_Camera;        //HUD POS TRANS
    public GameObject HUD;
    public GameObject HUDCamPos;
    public GameObject HudDmg_Text;  // HUD DMG TEXT
    
    

    private void LateUpdate()
    {
        ScreenToWorld();
    }



    void ScreenToWorld()
    {
        Vector3 HUD_POS;
        HUD_POS = HUDCamPos.transform.position;
        Vector3 screenPos = Camera.main.WorldToScreenPoint(HUD_POS);
        Vector3 viewPos = Camera.main.ScreenToViewportPoint(screenPos);
        Vector3 worldpos = UI_Camera.ViewportToWorldPoint(viewPos);

        HUD.transform.position = worldpos;
    }

    
}
