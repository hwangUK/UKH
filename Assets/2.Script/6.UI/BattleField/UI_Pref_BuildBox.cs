using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Pref_BuildBox : MonoBehaviour {

	public GameObject BuildBoxOpenPref;
	GameObject BoxInstance;
	GameObject Canvas_P;
	// Use this for initialization
	void Start () {
		Canvas_P = GameObject.FindWithTag ("Pref_UI_BuildBox");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OPEN_Build_UI(){

		BoxInstance = Instantiate (BuildBoxOpenPref,gameObject.transform.Find("ButtonBuildOPEN").transform.position, gameObject.transform.Find("ButtonBuildOPEN").transform.rotation);
		BoxInstance.transform.parent = Canvas_P.transform;
		BoxInstance.transform.localScale = new Vector3 (1f, 1f, 1f);
		BoxInstance.transform.localPosition = new Vector3(BoxInstance.transform.localPosition.x-100f,BoxInstance.transform.localPosition.y,BoxInstance.transform.localPosition.z);

	}
}
