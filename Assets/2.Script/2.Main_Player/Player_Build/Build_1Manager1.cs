using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Build_1Manager1 : MonoBehaviour {
	public GameObject Unit;

	public int Health = 1000;

	public float delayTime;
	float currentTime;

	// Use this for initialization
	void Start () {
		currentTime = 0.0f;
		}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;

		if (currentTime >= delayTime) {
			Instantiate (Unit, new Vector3(transform.position.x, transform.position.y + 1.7f,transform.position.z), transform.rotation);
			currentTime = 0.0f;
		}
	}		
}
