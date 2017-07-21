using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AI_Move : MonoBehaviour {
	float timer;
	//Transform gameobjPos;
	//Splayer sp;
	// Use this for initialization
	void Start () {

		timer = 0f;
	//	sp = GetComponent<Splayer> ();
	//	gameobjPos = sp.gameObject.GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		timer = timer + Time.deltaTime;

		if (timer >= 3 && timer <=5) {
			transform.Translate (Vector3.zero);
			Debug.Log ("3 STOP");
		} else if (timer > 5) {
			timer = 0f;
			Debug.Log ("5 STOP");
		}
		else
			transform.Translate(Vector3.forward * 2f * Time.deltaTime);
		//Vector3 TargetPos = new Vector3(gameobjPos.transform.position.x,gameobjPos.transform.position.y,gameobjPos.transform.position.z));

	}
}
