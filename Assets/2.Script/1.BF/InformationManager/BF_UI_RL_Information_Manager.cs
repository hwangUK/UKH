using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BF_UI_RL_Information_Manager : MonoBehaviour
{

    public Text Mineral_msg;
    public Text DefenceBuild_msg;
    public Text ExpMon_msg;
    public Text GoldMon_msg;

    private void Start()
    {
        Mineral_msg = gameObject.transform.GetChild(0).GetChild(1).GetComponent<Text>();
        DefenceBuild_msg = gameObject.transform.GetChild(1).GetChild(1).GetComponent<Text>();
        ExpMon_msg = gameObject.transform.GetChild(2).GetChild(1).GetComponent<Text>();
        GoldMon_msg = gameObject.transform.GetChild(3).GetChild(1).GetComponent<Text>();

        ExpMon_msg.text = "";
        Mineral_msg.text = "";
        DefenceBuild_msg.text = "";
        GoldMon_msg.text = "";
    }

    public void Open_Mineral()
    {
        gameObject.transform.GetChild(0).GetChild(0).gameObject.SetActive(true); //메인플레이어 스크립트 MainPlayer에서 open
        Debug.Log("OPEN_MIN");
    }

    public void Open_Defence_Build()
    {
        gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(true); // 방어물오브젝트 스크립트 Defence_HP에서 open
    }

    public void Open_ExpMon()
    {
        gameObject.transform.GetChild(2).GetChild(0).gameObject.SetActive(true); // 정글몬스터 스크립트 HUD_Add_BF_ExpMon에서 open
    }

    public void Open_GoldMon()
    {
        gameObject.transform.GetChild(3).GetChild(0).gameObject.SetActive(true); // 
    }

    //----------------------------------------------------------------------------

    public void Close_Mineral()
    {
        gameObject.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
    }

    public void Close_Defence_Build()
    {
        gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
    }

    public void Close_ExpMon()
    {
        gameObject.transform.GetChild(2).GetChild(0).gameObject.SetActive(false);
    }

    public void Close_GoldMon()
    {
        gameObject.transform.GetChild(3).GetChild(0).gameObject.SetActive(false);
    }
}