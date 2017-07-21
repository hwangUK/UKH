using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Build_Destroy : MonoBehaviour {

	//public GameObject SPlayer;
	//Splayer _splayer ;

	void Start(){
		
	//	_splayer = SPlayer.GetComponent<Splayer> ();
		//SPlayerInstance = _splayer.gameObject.GetComponent<Splayer> () as GameObject;
	}

	public void BuildUI_Destroy(){
		Destroy(gameObject);

	}


}
