using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cha_Del : MonoBehaviour {

	public void Click_Del()
    {
        transform.GetChild(1).gameObject.SetActive(true);
    }

    public void Click_Real_del()
    {
        SaveUserInformation.SaveDEFALT();
        if(Player.MODEL.gameObject != null)
        {
            Destroy(Player.MODEL.gameObject);
        }
        if(GameObject.Find("SelectRobbyManager").gameObject != null)
        {
            Destroy(GameObject.Find("SelectRobbyManager").gameObject);
        }
        SceneManager.LoadScene(1);
    }

    public void Click_Cancle()
    {
        transform.GetChild(1).gameObject.SetActive(false);
    }
}
