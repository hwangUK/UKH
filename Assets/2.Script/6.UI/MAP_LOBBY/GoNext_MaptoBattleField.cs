using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNext_MaptoBattleField : MonoBehaviour {

    public GameObject ISATK;
    public GameObject ISDEF;
    public GameObject MYSTAGE_01;
    public GameObject MYSTAGE_02;
    public GameObject MYSTAGE_03;

    public void ClickMapStage_MY()
    {        
        if (Infor_MapManager.MapType == 1 && Player.NewPlayer.STAGE_01 == 1)
        {
            Player.NewPlayer.IsATKDEF_12 = 2;
            Instantiate(MYSTAGE_01, this.transform.GetChild(2).transform);
        }
        
        else if (Infor_MapManager.MapType == 2 && Player.NewPlayer.STAGE_02 == 1)
        {
            Player.NewPlayer.IsATKDEF_12 = 2;
            Instantiate(MYSTAGE_02, this.transform.GetChild(2).transform);
        }
        
        else if (Infor_MapManager.MapType == 3 && Player.NewPlayer.STAGE_03 == 1)
        {
            Player.NewPlayer.IsATKDEF_12 = 2;
            Instantiate(MYSTAGE_03, this.transform.GetChild(2).transform);
        }
    }

    public void ClickMapStage()
    {        
        if(Infor_MapManager.MapType == 1 && Player.NewPlayer.STAGE_01 == 0)
        {
             Player.NewPlayer.IsATKDEF_12 = 1;
             Instantiate(ISATK,this.transform.GetChild(2).transform);
                                  
        } 
        else if(Infor_MapManager.MapType == 1 && Player.NewPlayer.STAGE_01 == 1)
        {
           
             Player.NewPlayer.IsATKDEF_12 = 2;
             Instantiate(ISDEF, this.transform.GetChild(2).transform);
           
        }

        if (Infor_MapManager.MapType == 2 && Player.NewPlayer.STAGE_02 == 0)
        {
            Player.NewPlayer.IsATKDEF_12 = 1;
            Instantiate(ISATK, this.transform.GetChild(2).transform);

        }
        else if (Infor_MapManager.MapType == 2 && Player.NewPlayer.STAGE_02 == 1)
        {

            Player.NewPlayer.IsATKDEF_12 = 2;
            Instantiate(ISDEF, this.transform.GetChild(2).transform);

        }

        if (Infor_MapManager.MapType == 3 && Player.NewPlayer.STAGE_03 == 0)
        {
            Player.NewPlayer.IsATKDEF_12 = 1;
            Instantiate(ISATK, this.transform.GetChild(2).transform);

        }
        else if (Infor_MapManager.MapType == 3 && Player.NewPlayer.STAGE_03 == 1)
        {

            Player.NewPlayer.IsATKDEF_12 = 2;
            Instantiate(ISDEF, this.transform.GetChild(2).transform);

        }
    }
    public void Click_Back()
    {
        if (Player.MODEL.gameObject != null)
        {
            Destroy(Player.MODEL.gameObject);
        }
        if (GameObject.Find("SelectRobbyManager").gameObject != null)
        {
            Destroy(GameObject.Find("SelectRobbyManager").gameObject);
        }
        SceneManager.LoadScene(3);
    }

}
