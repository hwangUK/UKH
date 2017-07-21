using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_MainCamManager : MonoBehaviour {

	public GameObject Follow_Player;
	public GameObject Follow_Cam;
	public float Height_Distance = 40f;
	public float Width_Distance = -40f;
	public float RotateX = 0.4f;
	public float RotateY = -0.1f;

	// Update is called once per frame
	void LateUpdate () {

		Follow_Cam.transform.position = Follow_Player.transform.position + new Vector3 (0f, Height_Distance, Width_Distance);
		Follow_Cam.transform.rotation = new Quaternion (RotateX, RotateY, 0f, 1f);
	}
}
