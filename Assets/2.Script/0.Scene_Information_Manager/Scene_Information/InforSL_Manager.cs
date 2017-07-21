using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InforSL_Manager : MonoBehaviour {


	void Start(){
        GameObject.Find("SelectRobbyManager").GetComponent<PlayerMainEventManager>().enabled = true; // 침략 활성화
        GameInformation.SetActive_True_Model (Player.MODEL);
		ResizeInGameModelPosition ();        
	}

	public static void ResizeInGameModelPosition(){
		Player.MODEL.transform.localPosition = new Vector3 (-2f, -4f, 110);
        //Player.MODEL.transform.localRotation = new Quaternion(0f, -210f, 0f,0f);
	}

}
