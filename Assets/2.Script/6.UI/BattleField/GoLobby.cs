using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoLobby : MonoBehaviour {

    // Use this for initialization
    public Text tSkillPoint;
    public Text tResorcesPoint;

    private Text Get_Win_EXP_UI;
    private Text Get_Lose_EXP_UI;

    private void Start()
    {
        Get_Lose_EXP_UI = transform.GetChild(5).GetChild(4).GetComponent<Text>();
        Get_Win_EXP_UI = transform.GetChild(4).GetChild(4).GetComponent<Text>();

        Get_Win_EXP_UI.text = "+" + GameObject.Find("0.BattleFieldManager").GetComponent<InforBF_Manager>().PlayerWin_EXP.ToString();
        Get_Lose_EXP_UI.text = "+" + GameObject.Find("0.BattleFieldManager").GetComponent<InforBF_Manager>().PlayerLose_EXP.ToString();
    }

    void Update()
    {
        tSkillPoint.text = IG_MainPlayer.LVUP_Point.ToString();
        tResorcesPoint.text = Player.NewPlayer.Resources.ToString();

    }

    public void Go_Lobby()
    {                 
               
        if (Player.MODEL != null)
        {
            Destroy(Player.MODEL);
            Destroy(GameObject.Find("SelectRobbyManager").gameObject);
        }

        IG_MainPlayer.LVUP_Point = 0;
        Player.NewPlayer.Resources = 0;
        Player.NewPlayer.IsATKDEF_12 = 0;
        SaveUserInformation.SavePlayerToUserInformation();

        SceneManager.LoadScene(3);
    }

    public void Back_Lobby()
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
