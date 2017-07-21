using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjManager : MonoBehaviour {

	//public Splayer sp;
	// Use this for initialization
	void Start () {
		StartCoroutine (this.Chk ());
		
	}

	IEnumerator Chk(){
		yield return new WaitForSeconds(0.25f);
		StartCoroutine(this.Chk ());

		RaycastHit hit;
		Physics.Raycast (transform.position, transform.forward, out hit, 0.5f);

		if (hit.collider) {
			if (hit.collider.tag == "Obj") {
				this.transform.Translate (Vector3.zero);
			}
		}
	}

}
