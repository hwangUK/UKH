using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankList_Main_Manager : MonoBehaviour {


    Map_Open_UI MOU;
	// Use this for initialization
	void Start () {

        MOU = GameObject.Find("Main_Canvas").transform.GetChild(3).GetComponent<Map_Open_UI>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Close_RankUI()
    {
        MOU.Close_UI();
    }
}
