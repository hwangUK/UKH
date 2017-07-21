using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadUserInformation {

   public static void LoadServerTOUserInformation()
    {


        UserInformation.Instance.USERNAME = PlayerPrefs.GetString("USER_NAME");
        UserInformation.Instance.USERLEVEL = PlayerPrefs.GetInt("USER_LEVEL");
        UserInformation.Instance.ISFIRST = PlayerPrefs.GetInt("USER_ISFIRST");
        UserInformation.Instance.MODELTYPE = PlayerPrefs.GetInt("USER_MTYPE");
        UserInformation.Instance.SKILLUPPOINT = PlayerPrefs.GetInt("USER_SKILLUPPOINT");
        UserInformation.Instance.SPECIESTYPE =  PlayerPrefs.GetInt("USER_STYPE");
        UserInformation.Instance.EXP_CURRENT = PlayerPrefs.GetInt("USER_EXP_C");
        UserInformation.Instance.EXP_MAX = PlayerPrefs.GetInt("USER_EXP_MAX");
        UserInformation.Instance.ISNOWSTAGE = PlayerPrefs.GetInt("USER_NOWSTAGE");
        
        UserInformation.Instance.STAGE01_U = PlayerPrefs.GetInt("USER_STAGE01");
        UserInformation.Instance.STAGE02_U = PlayerPrefs.GetInt("USER_STAGE02");
        UserInformation.Instance.STAGE03_U = PlayerPrefs.GetInt("USER_STAGE03");
        UserInformation.Instance.STAGE04_U = PlayerPrefs.GetInt("USER_STAGE04");
        UserInformation.Instance.STAGE05_U = PlayerPrefs.GetInt("USER_STAGE05");
        UserInformation.Instance.STAGE06_U = PlayerPrefs.GetInt("USER_STAGE06");
        UserInformation.Instance.STAGE07_U = PlayerPrefs.GetInt("USER_STAGE07");
        UserInformation.Instance.STAGE08_U = PlayerPrefs.GetInt("USER_STAGE08");
        UserInformation.Instance.STAGE09_U = PlayerPrefs.GetInt("USER_STAGE09");
        UserInformation.Instance.STAGE10_U = PlayerPrefs.GetInt("USER_STAGE10");
                                                                        
        UserInformation.Instance.STAGE11_U = PlayerPrefs.GetInt("USER_STAGE11");
        UserInformation.Instance.STAGE12_U = PlayerPrefs.GetInt("USER_STAGE12");
        UserInformation.Instance.STAGE13_U = PlayerPrefs.GetInt("USER_STAGE13");
        UserInformation.Instance.STAGE14_U = PlayerPrefs.GetInt("USER_STAGE14");
        UserInformation.Instance.STAGE15_U = PlayerPrefs.GetInt("USER_STAGE15");
        UserInformation.Instance.STAGE16_U = PlayerPrefs.GetInt("USER_STAGE16");
        UserInformation.Instance.STAGE17_U = PlayerPrefs.GetInt("USER_STAGE17");
        UserInformation.Instance.STAGE18_U = PlayerPrefs.GetInt("USER_STAGE18");
        UserInformation.Instance.STAGE19_U = PlayerPrefs.GetInt("USER_STAGE19");
        UserInformation.Instance.STAGE20_U = PlayerPrefs.GetInt("USER_STAGE20");
                                                                        
        UserInformation.Instance.STAGE21_U = PlayerPrefs.GetInt("USER_STAGE21");
        UserInformation.Instance.STAGE22_U = PlayerPrefs.GetInt("USER_STAGE22");
        UserInformation.Instance.STAGE23_U = PlayerPrefs.GetInt("USER_STAGE23");
        UserInformation.Instance.STAGE24_U = PlayerPrefs.GetInt("USER_STAGE24");
        UserInformation.Instance.STAGE25_U = PlayerPrefs.GetInt("USER_STAGE25");
        UserInformation.Instance.STAGE26_U = PlayerPrefs.GetInt("USER_STAGE26");
        UserInformation.Instance.STAGE27_U = PlayerPrefs.GetInt("USER_STAGE27");
        UserInformation.Instance.STAGE28_U = PlayerPrefs.GetInt("USER_STAGE28");
        UserInformation.Instance.STAGE29_U = PlayerPrefs.GetInt("USER_STAGE29");
        UserInformation.Instance.STAGE30_U = PlayerPrefs.GetInt("USER_STAGE30");
                                                                       
        UserInformation.Instance.STAGE31_U = PlayerPrefs.GetInt("USER_STAGE31");
        UserInformation.Instance.STAGE32_U = PlayerPrefs.GetInt("USER_STAGE32");

        Debug.Log("LoadName_ServerTOUser   : " + UserInformation.Instance.USERNAME);
        Debug.Log("LoadLevel_ServerTOUser  : " + UserInformation.Instance.USERLEVEL);
        Debug.Log("LoadFirst_ServerTOUser  : " + UserInformation.Instance.ISFIRST);
        Debug.Log("LoadModel_ServerTOUser  : " + UserInformation.Instance.MODELTYPE);
        Debug.Log("LoadSpoint_ServerTOUser : " + UserInformation.Instance.SKILLUPPOINT);
        Debug.Log("LoadStype_ServerTOUser : " + UserInformation.Instance.SPECIESTYPE);
        Debug.Log("LoadNOWexp_ServerTOUser : " + UserInformation.Instance.EXP_CURRENT);
        Debug.Log("LoadMAXexp_ServerTOUser : " + UserInformation.Instance.EXP_MAX);
        Debug.Log("LoadStage_ServerTOUser : " + UserInformation.Instance.ISNOWSTAGE);



        /*if (PlayerPrefs.GetString("USER_NAME") == "NONAME")
        {
            UserInformation.Instance.USERNAME = "NONAME";
            Debug.Log("new");
        }else {
            UserInformation.Instance.USERNAME = PlayerPrefs.GetString("USER_NAME");
            Debug.Log("loadname");
        }
            
        
        if (PlayerPrefs.GetInt("USER_LEVEL") == 0)
        {
            UserInformation.Instance.USERLEVEL = 1;
            Debug.Log("new");
        }else  {
            UserInformation.Instance.USERLEVEL = PlayerPrefs.GetInt("USER_LEVEL");
            Debug.Log("loadlevel");
        }
            

        if (PlayerPrefs.GetInt("USER_ISFIRST") == 0) {
            UserInformation.Instance.ISFIRST = 0;
            Debug.Log("new");
        }else  {
            UserInformation.Instance.ISFIRST = 1;
            Debug.Log("loadfirst");
        }
            

        if (PlayerPrefs.GetInt("USER_MTYPE") == 0) {
            UserInformation.Instance.MODELTYPE = 0;
            Debug.Log("new");
        } else {
            UserInformation.Instance.MODELTYPE = PlayerPrefs.GetInt("USER_MTYPE");
            Debug.Log("loadmodel : "+ UserInformation.Instance.MODELTYPE);
        }

        if (PlayerPrefs.GetInt("USER_SKILLUPPOINT") == 0)
        {
            UserInformation.Instance.SKILLUPPOINT = 0;
            Debug.Log("new");
        }
        else
        {
            UserInformation.Instance.SKILLUPPOINT = PlayerPrefs.GetInt("USER_SKILLUPPOINT");
            Debug.Log("LoadSpoint  : " + UserInformation.Instance.SKILLUPPOINT);
        }
        */


    }
}
