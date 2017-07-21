using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Open_UI : MonoBehaviour
{


    public GameObject UI_Prefeb;
    private GameObject ButtonUI;
    /*bool IsOpen = false;
	static int Counter_OPEN_UI_INMAP = 0;

	public void CounterM(){
		if (Counter_OPEN_UI_INMAP == 0) {
			IsOpen = true;
			Open_UI ();
			Counter_OPEN_UI_INMAP = 1;
		} else {
			Counter_OPEN_UI_INMAP = 0;
			IsOpen = false;
			Open_UI ();
		}
			
	}*/

    public void Open_UI()
    {


        ButtonUI = Instantiate(UI_Prefeb, transform.position, transform.rotation);
        ButtonUI.transform.parent = GameObject.Find("Main_Canvas").transform;
        ButtonUI.transform.localPosition = new Vector3(1f, 1f, -400f);
        ButtonUI.transform.localScale = new Vector3(1f, 1f, 1f);
        Debug.Log("OPEN");


        //Instantiate (UI_Prefeb, transform.position, transform.rotation);
    }

    public void Close_UI()
    {
        Destroy(ButtonUI);
        Debug.Log("DESTROY");
    }
}
