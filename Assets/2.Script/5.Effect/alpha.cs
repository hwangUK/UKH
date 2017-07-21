using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alpha : MonoBehaviour {


	// Use this for initialization
	void Start () {
		StartCoroutine (alphaFunc());
	}


	IEnumerator alphaFunc(){
		GetComponent<MeshRenderer> ().material.color = new Color32(255,255,255,0);
		//Debug.Log ("OFF");
		yield return new WaitForSeconds(Random.Range(0.1f,1.0f));
		GetComponent<MeshRenderer> ().material.color = new Color32(222,125,205,100);
		//Debug.Log ("ON");
		yield return new WaitForSeconds(Random.Range(0.1f,2.0f));
		StartCoroutine( alphaFunc());
	}
}
