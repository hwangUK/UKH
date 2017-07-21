using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {
    private Text[] UI_LvExp; 

    public static Information_Base_Player NewPlayer;
    public static GameObject MODEL;

    public GameObject Model_Defalt;
    public GameObject Model_CREATER_100;
    public GameObject Model_CREATER_110;
    public GameObject Model_CREATER_111;
    public GameObject Model_CREATER_112;
    public GameObject Model_CREATER_113;
    public GameObject Model_CREATER_120;
    public GameObject Model_CREATER_121;
    public GameObject Model_CREATER_122;
    public GameObject Model_CREATER_123;



    // Use this for initialization
    private void Awake()
    {        
        LoadInformation();
        DontDestroyOnLoad(this.gameObject);
    }
    
    void Start ()
    {
        UI_LvExp = this.transform.GetChild(0).GetComponentsInChildren<Text>();
        Set_UI_LvEXP();
        SaveUserInformation.SaveUserInformationTOServer();
    }
	
    void Set_UI_LvEXP()
    {
        UI_LvExp[0].text = UserInformation.Instance.USERLEVEL.ToString();
        UI_LvExp[1].text = NewPlayer.Player_MainCurrentEXP.ToString() + " / " + NewPlayer.Player_MainMaxEXP.ToString();

        
    }
    void LoadInformation()
    {
        NewPlayer = new Information_Base_Player();

        NewPlayer.playerName = UserInformation.Instance.USERNAME;
        NewPlayer.playerLevel = UserInformation.Instance.USERLEVEL;
        NewPlayer.IsFirst = UserInformation.Instance.ISFIRST;
        NewPlayer.playerMtype = UserInformation.Instance.MODELTYPE;
        NewPlayer.PlayerSkillUpPoint = UserInformation.Instance.SKILLUPPOINT;
        NewPlayer.PlayerSpeciesType = UserInformation.Instance.SPECIESTYPE;
        NewPlayer.Player_MainCurrentEXP = UserInformation.Instance.EXP_CURRENT;
        NewPlayer.Player_MainMaxEXP = UserInformation.Instance.USERLEVEL * 150;
        //NewPlayer.IsNowStage = UserInformation.Instance.ISNOWSTAGE;
        
        NewPlayer.STAGE_01 = UserInformation.Instance.STAGE01_U;
        NewPlayer.STAGE_02 = UserInformation.Instance.STAGE02_U;
        NewPlayer.STAGE_03 = UserInformation.Instance.STAGE03_U;
        NewPlayer.STAGE_04 = UserInformation.Instance.STAGE04_U;
        NewPlayer.STAGE_05 = UserInformation.Instance.STAGE05_U;
        NewPlayer.STAGE_06 = UserInformation.Instance.STAGE06_U;
        NewPlayer.STAGE_07 = UserInformation.Instance.STAGE07_U;
        NewPlayer.STAGE_08 = UserInformation.Instance.STAGE08_U;
        NewPlayer.STAGE_09 = UserInformation.Instance.STAGE09_U;
        NewPlayer.STAGE_10 = UserInformation.Instance.STAGE10_U;
                                                              
        NewPlayer.STAGE_11 = UserInformation.Instance.STAGE11_U;
        NewPlayer.STAGE_12 = UserInformation.Instance.STAGE12_U;
        NewPlayer.STAGE_13 = UserInformation.Instance.STAGE13_U;
        NewPlayer.STAGE_14 = UserInformation.Instance.STAGE14_U;
        NewPlayer.STAGE_15 = UserInformation.Instance.STAGE15_U;
        NewPlayer.STAGE_16 = UserInformation.Instance.STAGE16_U;
        NewPlayer.STAGE_17 = UserInformation.Instance.STAGE17_U;
        NewPlayer.STAGE_18 = UserInformation.Instance.STAGE18_U;
        NewPlayer.STAGE_19 = UserInformation.Instance.STAGE19_U;
        NewPlayer.STAGE_20 = UserInformation.Instance.STAGE20_U;
                                                              
        NewPlayer.STAGE_21 = UserInformation.Instance.STAGE21_U;
        NewPlayer.STAGE_22 = UserInformation.Instance.STAGE22_U;
        NewPlayer.STAGE_23 = UserInformation.Instance.STAGE23_U;
        NewPlayer.STAGE_24 = UserInformation.Instance.STAGE24_U;
        NewPlayer.STAGE_25 = UserInformation.Instance.STAGE25_U;
        NewPlayer.STAGE_26 = UserInformation.Instance.STAGE26_U;
        NewPlayer.STAGE_27 = UserInformation.Instance.STAGE27_U;
        NewPlayer.STAGE_28 = UserInformation.Instance.STAGE28_U;
        NewPlayer.STAGE_29 = UserInformation.Instance.STAGE29_U;
        NewPlayer.STAGE_30 = UserInformation.Instance.STAGE30_U;
                                                              
        NewPlayer.STAGE_31 = UserInformation.Instance.STAGE31_U;
        NewPlayer.STAGE_32 = UserInformation.Instance.STAGE32_U;
        

        MakeModel();

        Debug.Log("LOAD playername  :  " + NewPlayer.playerName);
        Debug.Log("LOAD playerlevel :  " + NewPlayer.playerLevel);
        Debug.Log("LOAD Isfirst     :  " + NewPlayer.IsFirst);
        Debug.Log("LOAD Modeltype   :  " + NewPlayer.playerMtype);
        Debug.Log("LOAD Spoint      :  " + NewPlayer.PlayerSkillUpPoint);
        Debug.Log("LOAD EXP         :  " + NewPlayer.Player_MainCurrentEXP);
        Debug.Log("LOAD MAXEXP      :  " + NewPlayer.Player_MainMaxEXP);
       // Debug.Log("LOAD STAGE       :  " + NewPlayer.IsNowStage);




    }

    public void MakeModel()
    {
        MODEL = Instantiate(Model_Defalt);
        DontDestroyOnLoad(MODEL);

        if (Player.NewPlayer.PlayerSpeciesType == 1 && Player.NewPlayer.playerMtype == 0)
        {
            return;
        }
        else if (Player.NewPlayer.PlayerSpeciesType == 1 && Player.NewPlayer.playerMtype == 100)
        {
            Instantiate(Model_CREATER_100,MODEL.transform.GetChild(3));
            //DontDestroyOnLoad(MODEL);
        }
        else if (Player.NewPlayer.PlayerSpeciesType == 1 && Player.NewPlayer.playerMtype == 110)
        {
            Instantiate(Model_CREATER_110, MODEL.transform.GetChild(3));
            //DontDestroyOnLoad(MODEL);
        }
        else if (Player.NewPlayer.PlayerSpeciesType == 1 && Player.NewPlayer.playerMtype == 111)
        {
            Instantiate(Model_CREATER_111, MODEL.transform.GetChild(3));
            //DontDestroyOnLoad(MODEL);
        }
        else if (Player.NewPlayer.PlayerSpeciesType == 1 && Player.NewPlayer.playerMtype == 112)
        {
            Instantiate(Model_CREATER_112, MODEL.transform.GetChild(3));
            //DontDestroyOnLoad(MODEL);
        }
        else if (Player.NewPlayer.PlayerSpeciesType == 1 && Player.NewPlayer.playerMtype == 113)
        {
            Instantiate(Model_CREATER_113, MODEL.transform.GetChild(3));
            //DontDestroyOnLoad(MODEL);
        }
        else if (Player.NewPlayer.PlayerSpeciesType == 1 && Player.NewPlayer.playerMtype == 120)
        {
            Instantiate(Model_CREATER_120, MODEL.transform.GetChild(3));
            //DontDestroyOnLoad(MODEL);
        }
        else if (Player.NewPlayer.PlayerSpeciesType == 1 && Player.NewPlayer.playerMtype == 121)
        {
            Instantiate(Model_CREATER_121, MODEL.transform.GetChild(3));
            //DontDestroyOnLoad(MODEL);
        }
        else if (Player.NewPlayer.PlayerSpeciesType == 1 && Player.NewPlayer.playerMtype == 122)
        {
            Instantiate(Model_CREATER_122, MODEL.transform.GetChild(3));
            //DontDestroyOnLoad(MODEL);
        }
        else if (Player.NewPlayer.PlayerSpeciesType == 1 && Player.NewPlayer.playerMtype == 123)
        {
            Instantiate(Model_CREATER_123, MODEL.transform.GetChild(3));
            //DontDestroyOnLoad(MODEL);
        }
    }
}
