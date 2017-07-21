using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InforBF_Manager : MonoBehaviour {

    GameObject P_Gob;
    SkillUI_Open SkillUI_Get;
    GameObject UI_GET;

    public int PlayerWin_EXP = 2;
    public int PlayerLose_EXP = 1;

    //미네랄
    GameObject[] respawn_Load_Min;
    public int Respawn_Length_Min = 13;
    public GameObject Mineral;

    //몬스터
    GameObject[] respawn_Load_ExpMon;
    public int Respawn_Length_ExpMon = 13;
    public GameObject ExpMon;


   
    void Start () {
        PlayerMainEventManager.Invade_Stage_01 = true;
        PlayerMainEventManager.Invade_Stage_02 = true;
        PlayerMainEventManager.Invade_Stage_03 = true; // 침략 비활성화

        StartCoroutine( GameObject.Find("SelectRobbyManager").transform.GetChild(0).GetChild(1).GetComponent<Alpha>().Alpha_FadeIn());
        GameObject.Find("SelectRobbyManager").transform.GetChild(1).GetChild(1).gameObject.SetActive(true);
        P_Gob = GameObject.FindGameObjectWithTag("Cha").gameObject;
        UI_GET = P_Gob.transform.GetChild(6).transform.GetChild(8).gameObject;

        
        respawn_Load_Min = new GameObject[Respawn_Length_Min];
        Respawn_Min();
        respawn_Load_ExpMon = new GameObject[Respawn_Length_ExpMon];
        Respawn_ExpMon();

        CheckAndSetting_IsAtkOrDef();

        P_Gob.GetComponent<IG_MainPlayer>().enabled = true;
    }

    public void Respawn_Min()
    {
        for (int i = 0; i < respawn_Load_Min.Length; i++)
        {
            if (transform.GetChild(1).transform.GetChild(i).gameObject.activeSelf == false)
            {
                respawn_Load_Min[i] = transform.GetChild(1).GetChild(i).gameObject;
                respawn_Load_Min[i].SetActive(true);
                Instantiate(Mineral, respawn_Load_Min[i].transform);              
            }
            else
                return;

        }
    }

    public void Respawn_ExpMon()
    {
        for (int i = 0; i < respawn_Load_ExpMon.Length; i++)
        {
            if (transform.GetChild(2).transform.GetChild(i).gameObject.activeSelf == false)
            {
                respawn_Load_ExpMon[i] = transform.GetChild(2).GetChild(i).gameObject;
                respawn_Load_ExpMon[i].SetActive(true);
                Instantiate(ExpMon, respawn_Load_ExpMon[i].transform);
            }
            else
                return;

        }
    }

    private void CheckAndSetting_IsAtkOrDef()
    {
        GameInformation.SetActive_True_All(Player.MODEL);

        SkillUI_Get = GameObject.Find("Skill_Button").GetComponent<SkillUI_Open>();
        SkillUI_Get.SkillSetting();

        if (Player.NewPlayer.IsATKDEF_12 == 1)//공격
        {
            StartCoroutine(GameInformation.SYS_MSG("적의 요새가 견고해지기 전에 적의 본거지를 파괴하십시오",4f));
            UI_GET.SetActive(false);//채광끔
            GameObject.FindGameObjectWithTag("Win").transform.GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(false); //광물표시  
            
            Player.MODEL.transform.localPosition = new Vector3(55f, 1f, 311f);
            GameObject.FindGameObjectWithTag("Mon").transform.localPosition = new Vector3(1f, 1f, 1f);        
            //적에이아이 목표 변경
        }
        else //방어
        {
            StartCoroutine(GameInformation.SYS_MSG("자원을 채취하여 얻은 자원을 사용하여 스킬을 발동하고 적의 침입을 막아내십시오",4f));
            UI_GET.SetActive(true);//채광킴
            GameObject.FindGameObjectWithTag("Win").transform.GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(true); //광물표시

            Player.MODEL.transform.localPosition = new Vector3(-3f, 1f, -30f);
        }
    }

    public void Win()
    {
        

        if (GameObject.FindGameObjectWithTag("Win").transform.GetChild(4).gameObject.activeInHierarchy == false && GameObject.FindGameObjectWithTag("Win").transform.GetChild(5).gameObject.activeInHierarchy == false)
        {
            Infor_MapManager.AlreadyCall_01 = false;
            Infor_MapManager.AlreadyCall_02 = false;

            PlayerMainEventManager.Invade_Stage_01 = false;
            //1_STAGE=========================
            if (Infor_MapManager.MapType == 1 && Player.NewPlayer.IsATKDEF_12 == 1)
            {
                Player.NewPlayer.STAGE_01 = 1;
                PlayerMainEventManager.DelBoom_01 = false;
                Debug.Log("1스테이지 점령");
            }
            else if (Infor_MapManager.MapType == 1 && Player.NewPlayer.IsATKDEF_12 == 2)
            {
                //방어성공 레드붐 삭제 느낌표 삭제
                Player.NewPlayer.STAGE_01 = 1;
                PlayerMainEventManager.DelBoom_01 = true;
                Debug.Log("방어성공!!");
            }

            //2_STAGE=========================
            if (Infor_MapManager.MapType == 2 && Player.NewPlayer.IsATKDEF_12 == 1)
            {
                Player.NewPlayer.STAGE_02 = 1;

                PlayerMainEventManager.DelBoom_02 = false;
                Debug.Log("1스테이지 점령");
            }
            else if (Infor_MapManager.MapType == 2 && Player.NewPlayer.IsATKDEF_12 == 2)
            {
                //방어성공 레드붐 삭제 느낌표 삭제
                Player.NewPlayer.STAGE_02 = 1;
                PlayerMainEventManager.Invade_Stage_02 = false;
                PlayerMainEventManager.DelBoom_02 = true;
                Debug.Log("방어성공!!");
            }

            GameObject.FindGameObjectWithTag("Win").transform.GetChild(4).gameObject.SetActive(true);
            GameInformation.SetActive_True_Model(Player.MODEL);   

            Player.NewPlayer.Player_MainCurrentEXP += PlayerWin_EXP;

            int RemainEXP = 0;
            if (Player.NewPlayer.Player_MainCurrentEXP >= Player.NewPlayer.playerLevel * 150)
            {
                RemainEXP = Player.NewPlayer.Player_MainCurrentEXP - (Player.NewPlayer.playerLevel * 150);
                Player.NewPlayer.playerLevel += 1;
                Player.NewPlayer.PlayerSkillUpPoint += 1;
                Player.NewPlayer.Player_MainCurrentEXP = RemainEXP;
                StartCoroutine(GameInformation.SYS_MSG("***축하합니다 레벨이 올랐습니다***", 5f));

            }
            SaveUserInformation.SavePlayerToUserInformation();
        }

    }

    public void Lose()
    {
        if (GameObject.FindGameObjectWithTag("Win").transform.GetChild(5).gameObject.activeInHierarchy == false && GameObject.FindGameObjectWithTag("Win").transform.GetChild(4).gameObject.activeInHierarchy == false)
        {
            GameObject.FindGameObjectWithTag("Win").transform.GetChild(5).gameObject.SetActive(true);
            GameInformation.SetActive_True_Model(Player.MODEL);

            if (Infor_MapManager.MapType == 1 && Player.NewPlayer.IsATKDEF_12 == 2)
            {
                Player.NewPlayer.STAGE_01 = 0;
                Debug.Log("점령지 방어실패");
            }


            Player.NewPlayer.Player_MainCurrentEXP += PlayerLose_EXP;

            Debug.Log("GET " + Player.NewPlayer.Player_MainCurrentEXP);

            int RemainEXP = 0;
            if (Player.NewPlayer.Player_MainCurrentEXP >= Player.NewPlayer.playerLevel * 150)
            {
                RemainEXP = Player.NewPlayer.Player_MainCurrentEXP - (Player.NewPlayer.playerLevel * 150);
                Player.NewPlayer.playerLevel += 1;
                Player.NewPlayer.PlayerSkillUpPoint += 1;
                Player.NewPlayer.Player_MainCurrentEXP = RemainEXP;
                StartCoroutine(GameInformation.SYS_MSG("***축하합니다 레벨이 올랐습니다***", 5f));
            }

            SaveUserInformation.SavePlayerToUserInformation();

        }
    }

}
