using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserInformation : MonoBehaviour{
    
    public static UserInformation Instance = null; //user instance

    private string UserName ="NONAME";//name
    private int UserLevel =0;//level
    private int IsFirst=0; //IsFirst
    private int modelType=0;
    private int skillUpPoint = 0;
    private int playerSpeciesType = 0;
    private int playerCurrentEXP = 0;
    private int playerMaxEXP = 0;
    private int IsNowStage = 1;
    
    private int stage01_u = 0;
    
//지금보니 for문을 사용해야 했다!1
    private int stage01_u = 0;
    private int stage02_u = 0;
    private int stage03_u = 0;
    private int stage04_u = 0;
    private int stage05_u = 0;
    private int stage06_u = 0;
    private int stage07_u = 0;
    private int stage08_u = 0;
    private int stage09_u = 0;
    private int stage10_u = 0;
    private int stage11_u = 0;
    private int stage12_u = 0;
    private int stage13_u = 0;
    private int stage14_u = 0;
    private int stage15_u = 0;           
    private int stage16_u = 0;
    private int stage17_u = 0;
    private int stage18_u = 0;
    private int stage19_u = 0;
    private int stage20_u = 0;
    private int stage21_u = 0;
    private int stage22_u = 0;
    private int stage23_u = 0;
    private int stage24_u = 0;
    private int stage25_u = 0;
    private int stage26_u = 0;
    private int stage27_u = 0;
    private int stage28_u = 0;
    private int stage29_u = 0;
    private int stage30_u = 0;
    private int stage31_u = 0;
    private int stage32_u = 0;

    public int ISFIRST { get { return IsFirst; } set { IsFirst = value; } }
    public int USERLEVEL { get { return UserLevel; } set { UserLevel = value; } }
    public string USERNAME { get { return UserName; } set { UserName = value; } }
    public int MODELTYPE { get { return modelType; } set { modelType = value; } }
    public int SKILLUPPOINT { get { return skillUpPoint; } set { skillUpPoint = value; } }
    public int SPECIESTYPE { get { return playerSpeciesType; } set { playerSpeciesType = value; } }
    public int EXP_CURRENT { get { return playerCurrentEXP; } set { playerCurrentEXP = value; } }
    public int EXP_MAX { get { return playerMaxEXP; } set { playerMaxEXP = value; } }
    public int ISNOWSTAGE { get { return IsNowStage; } set { IsNowStage = value; } }

    public int STAGE01_U { get { return stage01_u; } set { stage01_u = value; } }
    public int STAGE02_U { get { return stage02_u; } set { stage02_u = value; } }
    public int STAGE03_U { get { return stage03_u; } set { stage03_u = value; } }
    public int STAGE04_U { get { return stage04_u; } set { stage04_u = value; } }
    public int STAGE05_U { get { return stage05_u; } set { stage05_u = value; } }
    public int STAGE06_U { get { return stage06_u; } set { stage06_u = value; } }
    public int STAGE07_U { get { return stage07_u; } set { stage07_u = value; } }
    public int STAGE08_U { get { return stage08_u; } set { stage08_u = value; } }
    public int STAGE09_U { get { return stage09_u; } set { stage09_u = value; } }
    public int STAGE10_U { get { return stage10_u; } set { stage10_u = value; } }
    public int STAGE11_U { get { return stage11_u; } set { stage11_u = value; } }
    public int STAGE12_U { get { return stage12_u; } set { stage12_u = value; } }
    public int STAGE13_U { get { return stage13_u; } set { stage13_u = value; } }
    public int STAGE14_U { get { return stage14_u; } set { stage14_u = value; } }
    public int STAGE15_U { get { return stage15_u; } set { stage15_u = value; } }
    public int STAGE16_U { get { return stage16_u; } set { stage16_u = value; } }
    public int STAGE17_U { get { return stage17_u; } set { stage17_u = value; } }
    public int STAGE18_U { get { return stage18_u; } set { stage18_u = value; } }
    public int STAGE19_U { get { return stage19_u; } set { stage19_u = value; } }
    public int STAGE20_U { get { return stage20_u; } set { stage20_u = value; } }
    public int STAGE21_U { get { return stage21_u; } set { stage21_u = value; } }
    public int STAGE22_U { get { return stage22_u; } set { stage22_u = value; } }
    public int STAGE23_U { get { return stage23_u; } set { stage23_u = value; } }
    public int STAGE24_U { get { return stage24_u; } set { stage24_u = value; } }
    public int STAGE25_U { get { return stage25_u; } set { stage25_u = value; } }
    public int STAGE26_U { get { return stage26_u; } set { stage26_u = value; } }
    public int STAGE27_U { get { return stage27_u; } set { stage27_u = value; } }
    public int STAGE28_U { get { return stage28_u; } set { stage28_u = value; } }
    public int STAGE29_U { get { return stage29_u; } set { stage29_u = value; } }
    public int STAGE30_U { get { return stage30_u; } set { stage30_u = value; } }
    public int STAGE31_U { get { return stage31_u; } set { stage31_u = value; } }
    public int STAGE32_U { get { return stage32_u; } set { stage32_u = value; } }



    void Awake() {
        if(Instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
       
    }

    private void Start()
    {
        Debug.Log("U_Name    : "+Instance.UserName);
        Debug.Log("U_Level   : "+Instance.USERLEVEL);
        Debug.Log("U_Isfirst : "+Instance.ISFIRST);
        Debug.Log("U_Mtype   : "+Instance.MODELTYPE);
        Debug.Log("U_Spont   : "+Instance.SKILLUPPOINT);
        Debug.Log("U_EXP_C   : " + Instance.EXP_CURRENT);
        Debug.Log("U_EXP_MAX : " + Instance.EXP_MAX);
        Debug.Log("U_NowStage : " + Instance.ISNOWSTAGE);
    }


}

