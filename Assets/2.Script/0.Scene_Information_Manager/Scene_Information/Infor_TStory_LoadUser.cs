using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infor_TStory_LoadUser : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LoadUserInformation.LoadServerTOUserInformation();
        GameInformation.SYS_MSG("", 5f);

	}	
	
}
