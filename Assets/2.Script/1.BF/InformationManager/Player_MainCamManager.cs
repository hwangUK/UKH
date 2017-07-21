using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MainCamManager : MonoBehaviour {

	//public GameObject Follow_Player;
	public GameObject Follow_Cam;
	public float Height_Distance = 30f;
	public float Width_Distance = -20f;
	public float RotateX = 0f;
	public float RotateY = 0f;
	// Use this for initialization
	void Start () {
		//player = GetComponent<GameObject> ();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(Player.MODEL != null)
        {
            Follow_Cam.transform.position = Player.MODEL.transform.position + new Vector3(0f, Height_Distance, Width_Distance);
            Follow_Cam.transform.rotation = new Quaternion(RotateX, RotateY, 0f, 1f);
        }
		
		//Camera.main.transform.rotation = new Quaternion(player.transform.position.x+50f,player.transform.position.y+-5f,player.transform.position.z,0f);
	}
}
