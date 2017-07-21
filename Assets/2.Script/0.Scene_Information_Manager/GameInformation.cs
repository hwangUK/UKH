using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInformation {

	void Awake()
    {
        //DontDestroyOnLoad(gameObject);   //정보
    }

    public static void SetActive_True_Model(GameObject loadmodel)
    {
        loadmodel.transform.FindChild("Mesh_grp").gameObject.SetActive(true);
        loadmodel.transform.FindChild("UI Camera").gameObject.SetActive(false);
        loadmodel.transform.FindChild("HUD").gameObject.SetActive(false);
        loadmodel.transform.FindChild("UI_Manager").gameObject.SetActive(false);
    }

    
    public static void SetActive_False_All(GameObject loadmodel)
    {
        loadmodel.transform.FindChild("Mesh_grp").gameObject.SetActive(false);
        loadmodel.transform.FindChild("UI Camera").gameObject.SetActive(false);
        loadmodel.transform.FindChild("HUD").gameObject.SetActive(false);
        loadmodel.transform.FindChild("UI_Manager").gameObject.SetActive(false);
    }
    public static void SetActive_True_All(GameObject loadmodel)
    {
        loadmodel.transform.FindChild("Mesh_grp").gameObject.SetActive(true);
        loadmodel.transform.FindChild("UI Camera").gameObject.SetActive(true);
        loadmodel.transform.FindChild("HUD").gameObject.SetActive(true);
        loadmodel.transform.FindChild("UI_Manager").gameObject.SetActive(true);
    }

    public static void Mon_R_ColOn()
    {
        GameObject.FindGameObjectWithTag("Mon_R_ON").GetComponent<Collider>().enabled = true;
    }

    public static void Mon_R_ColOff()
    {
        GameObject.FindGameObjectWithTag("Mon_R_ON").GetComponent<Collider>().enabled = false;
    }

    public static void Mon_TargetDfault()
    {
        Mon_R_ON.TARGET = Mon_R_ON.Target_D;
    }

    public static IEnumerator SYS_MSG(string str , float runtime)
    {
        GameObject.FindGameObjectWithTag("SystemMSG").GetComponent<Text>().text = str;
        yield return new WaitForSeconds(runtime);
        GameObject.FindGameObjectWithTag("SystemMSG").GetComponent<Text>().text = "";
    }
    public static IEnumerator SYS_MSG2(string str, float runtime)
    {
        GameObject.FindGameObjectWithTag("SystemMSG2").GetComponent<Text>().text = str;
        yield return new WaitForSeconds(runtime);
        GameObject.FindGameObjectWithTag("SystemMSG2").GetComponent<Text>().text = "";
    }

    /* void MakeModel()
     {
         if (Player.NewPlayer.ModelType == 100)
         {
             MODEL = Instantiate(Model_baseSAC);
             DontDestroyOnLoad(MODEL);
         }
         else if (UserInformation.Instance.MODELTYPE == 200)
         {
             MODEL = Instantiate(Model_Robot);
             DontDestroyOnLoad(MODEL);
         }
     }

     /*public void LoadInstance()
     {
         PLAYER_INFORMATION = new Information_P_Definition_Jop();
         PLAYER_INFORMATION.playerLevel = UserInformation.Instance.USERLEVEL;
         PLAYER_INFORMATION.playerName = UserInformation.Instance.USERNAME;
         PLAYER_INFORMATION.TYPEofMODEL_Client = UserInformation.Instance.TYPEofMODEL;



         Debug.Log(PLAYER_INFORMATION.playerLevel+"LOAD SUCSESS!!");
         Debug.Log(PLAYER_INFORMATION.playerName + "LOAD SUCSESS!!");
         Debug.Log(PLAYER_INFORMATION.TYPEofMODEL_Client + "LOAD SUCSESS!!");

     }
     public void SaveInstance()
     {
         UserInformation.Instance.USERLEVEL = PLAYER_INFORMATION.playerLevel;
         UserInformation.Instance.USERNAME = PLAYER_INFORMATION.playerName;
         UserInformation.Instance.TYPEofMODEL = PLAYER_INFORMATION.TYPEofMODEL_Client;
     }*/







}
