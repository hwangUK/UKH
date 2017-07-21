using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTest : MonoBehaviour {

    public string _INPUT;
	// Use this for initialization
	void Start () {
        SaveTestPlayer(_INPUT);
	}
	
	

    void SaveTestPlayer(string Input)
    {
        if (Input == "DEF")
            SaveUserInformation.SaveDEFALT();
        else if (Input == "MAX")
            SaveUserInformation.SaveMAXLEVEL();
    }
}
