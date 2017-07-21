using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNext_CCtoSL : MonoBehaviour {

	public void GoNext_CreateCha_to_SelectLobby(){
        if(UserInformation.Instance.USERNAME == "NONAME" | UserInformation.Instance.SPECIESTYPE == 0)
        {
            Debug.Log("Name OR Species Is NULL");
           
        }
        else
        {
            SceneManager.LoadScene(3);
            UserInformation.Instance.ISFIRST = 1;
            SaveUserInformation.SaveUserInformationTOServer();
        }
		
	}
}
