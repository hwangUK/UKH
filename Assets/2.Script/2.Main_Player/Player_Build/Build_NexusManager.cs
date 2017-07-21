using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_NexusManager : MonoBehaviour {

	public int Health;
	public float Build_Nex_Up_RotateSpeed;
	public float Build_Nex_Mid_MoveSpeed;
	Transform nexusUp;
	Transform nexusMid;
	float delayTime;
	//Material simbol;

	// Use this for initialization
	void Start () {

		nexusUp = gameObject.transform.FindChild ("Nex_up");
		nexusMid = gameObject.transform.FindChild ("Nex_mid");
		delayTime = 0f;
		
	}
	
	// Update is called once per frame
	void Update () {
		delayTime = delayTime + Time.deltaTime;
		RotateObject ();
		UpDownObject ();
	}

	void RotateObject(){
		nexusUp.transform.Rotate (Build_Nex_Up_RotateSpeed, Build_Nex_Up_RotateSpeed, Build_Nex_Up_RotateSpeed);

		//childObj.transform.Rotate = new Vector3 (3f, 3f, 3f);
	}
	void UpDownObject(){
		if (delayTime < 2f) {
			nexusMid.transform.Translate (0f, Build_Nex_Mid_MoveSpeed, 0f);
		}

		else if (delayTime > 2f) {
			ChangeUpDown ();
			delayTime = 0f;
		}
	}

	void ChangeUpDown(){
		
			Build_Nex_Mid_MoveSpeed = -Build_Nex_Mid_MoveSpeed;			
	}

	//public void SetMySimbol(GameObject Player){
		//simbol = gameObject.GetComponent<Material> ();
		//
		//if (Player.tag == "PLAYER01") {
		//	simbol = Resources.Load("
		//}
	//}
}
