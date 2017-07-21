using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveUserInformation  {

    public static void SavePlayerToUserInformation()
    {
        UserInformation.Instance.USERNAME = Player.NewPlayer.playerName;
        UserInformation.Instance.USERLEVEL = Player.NewPlayer.playerLevel;
        UserInformation.Instance.ISFIRST = Player.NewPlayer.IsFirst;
        UserInformation.Instance.MODELTYPE = Player.NewPlayer.playerMtype;
        UserInformation.Instance.SKILLUPPOINT = Player.NewPlayer.PlayerSkillUpPoint;
        UserInformation.Instance.SPECIESTYPE = Player.NewPlayer.PlayerSpeciesType;
        UserInformation.Instance.EXP_CURRENT = Player.NewPlayer.Player_MainCurrentEXP;
        UserInformation.Instance.EXP_MAX = Player.NewPlayer.Player_MainMaxEXP;
        //UserInformation.Instance.ISNOWSTAGE = Player.NewPlayer.IsNowStage;

        UserInformation.Instance.STAGE01_U = Player.NewPlayer.STAGE_01;
        UserInformation.Instance.STAGE02_U = Player.NewPlayer.STAGE_02;
        UserInformation.Instance.STAGE03_U = Player.NewPlayer.STAGE_03;
        UserInformation.Instance.STAGE04_U = Player.NewPlayer.STAGE_04;
        UserInformation.Instance.STAGE05_U = Player.NewPlayer.STAGE_05;
        UserInformation.Instance.STAGE06_U = Player.NewPlayer.STAGE_06;
        UserInformation.Instance.STAGE07_U = Player.NewPlayer.STAGE_07;
        UserInformation.Instance.STAGE08_U = Player.NewPlayer.STAGE_08;
        UserInformation.Instance.STAGE09_U = Player.NewPlayer.STAGE_09;
        UserInformation.Instance.STAGE10_U = Player.NewPlayer.STAGE_10;

        UserInformation.Instance.STAGE11_U = Player.NewPlayer.STAGE_11;
        UserInformation.Instance.STAGE12_U = Player.NewPlayer.STAGE_12;
        UserInformation.Instance.STAGE13_U = Player.NewPlayer.STAGE_13;
        UserInformation.Instance.STAGE14_U = Player.NewPlayer.STAGE_14;
        UserInformation.Instance.STAGE15_U = Player.NewPlayer.STAGE_15;
        UserInformation.Instance.STAGE16_U = Player.NewPlayer.STAGE_16;
        UserInformation.Instance.STAGE17_U = Player.NewPlayer.STAGE_17;
        UserInformation.Instance.STAGE18_U = Player.NewPlayer.STAGE_18;
        UserInformation.Instance.STAGE19_U = Player.NewPlayer.STAGE_19;
        UserInformation.Instance.STAGE20_U = Player.NewPlayer.STAGE_20;

        UserInformation.Instance.STAGE21_U = Player.NewPlayer.STAGE_21;
        UserInformation.Instance.STAGE22_U = Player.NewPlayer.STAGE_22;
        UserInformation.Instance.STAGE23_U = Player.NewPlayer.STAGE_23;
        UserInformation.Instance.STAGE24_U = Player.NewPlayer.STAGE_24;
        UserInformation.Instance.STAGE25_U = Player.NewPlayer.STAGE_25;
        UserInformation.Instance.STAGE26_U = Player.NewPlayer.STAGE_26;
        UserInformation.Instance.STAGE27_U = Player.NewPlayer.STAGE_27;
        UserInformation.Instance.STAGE28_U = Player.NewPlayer.STAGE_28;
        UserInformation.Instance.STAGE29_U = Player.NewPlayer.STAGE_29;
        UserInformation.Instance.STAGE30_U = Player.NewPlayer.STAGE_30;

        UserInformation.Instance.STAGE31_U = Player.NewPlayer.STAGE_31;
        UserInformation.Instance.STAGE32_U = Player.NewPlayer.STAGE_32;

        Debug.Log("SAVE P_to_USER");
        //Debug.Log("U :"+UserInformation.Instance.EXP_CURRENT+"P :"+ Player.NewPlayer.Player_MainCurrentEXP);
    }

    public static void SaveUserInformationTOServer()
    {
        PlayerPrefs.SetString("USER_NAME", UserInformation.Instance.USERNAME);
        PlayerPrefs.SetInt("USER_LEVEL", UserInformation.Instance.USERLEVEL);
        PlayerPrefs.SetInt("USER_ISFIRST", UserInformation.Instance.ISFIRST);
        PlayerPrefs.SetInt("USER_MTYPE", UserInformation.Instance.MODELTYPE);
        PlayerPrefs.SetInt("USER_SKILLUPPOINT", UserInformation.Instance.SKILLUPPOINT);
        PlayerPrefs.SetInt("USER_STYPE", UserInformation.Instance.SPECIESTYPE);
        PlayerPrefs.SetInt("USER_EXP_C", UserInformation.Instance.EXP_CURRENT);
        PlayerPrefs.SetInt("USER_EXP_MAX", UserInformation.Instance.EXP_MAX);
        PlayerPrefs.SetInt("USER_NOWSTAGE", UserInformation.Instance.ISNOWSTAGE);

        PlayerPrefs.SetInt("USER_STAGE01", UserInformation.Instance.STAGE01_U);
        PlayerPrefs.SetInt("USER_STAGE02", UserInformation.Instance.STAGE02_U);
        PlayerPrefs.SetInt("USER_STAGE03", UserInformation.Instance.STAGE03_U);
        PlayerPrefs.SetInt("USER_STAGE04", UserInformation.Instance.STAGE04_U);
        PlayerPrefs.SetInt("USER_STAGE05", UserInformation.Instance.STAGE05_U);
        PlayerPrefs.SetInt("USER_STAGE06", UserInformation.Instance.STAGE06_U);
        PlayerPrefs.SetInt("USER_STAGE07", UserInformation.Instance.STAGE07_U);
        PlayerPrefs.SetInt("USER_STAGE08", UserInformation.Instance.STAGE08_U);
        PlayerPrefs.SetInt("USER_STAGE09", UserInformation.Instance.STAGE09_U);
        PlayerPrefs.SetInt("USER_STAGE10", UserInformation.Instance.STAGE10_U);

        PlayerPrefs.SetInt("USER_STAGE11", UserInformation.Instance.STAGE11_U);
        PlayerPrefs.SetInt("USER_STAGE12", UserInformation.Instance.STAGE12_U);
        PlayerPrefs.SetInt("USER_STAGE13", UserInformation.Instance.STAGE13_U);
        PlayerPrefs.SetInt("USER_STAGE14", UserInformation.Instance.STAGE14_U);
        PlayerPrefs.SetInt("USER_STAGE15", UserInformation.Instance.STAGE15_U);
        PlayerPrefs.SetInt("USER_STAGE16", UserInformation.Instance.STAGE16_U);
        PlayerPrefs.SetInt("USER_STAGE17", UserInformation.Instance.STAGE17_U);
        PlayerPrefs.SetInt("USER_STAGE18", UserInformation.Instance.STAGE18_U);
        PlayerPrefs.SetInt("USER_STAGE19", UserInformation.Instance.STAGE19_U);
        PlayerPrefs.SetInt("USER_STAGE20", UserInformation.Instance.STAGE20_U);

        PlayerPrefs.SetInt("USER_STAGE21", UserInformation.Instance.STAGE21_U);
        PlayerPrefs.SetInt("USER_STAGE22", UserInformation.Instance.STAGE22_U);
        PlayerPrefs.SetInt("USER_STAGE23", UserInformation.Instance.STAGE23_U);
        PlayerPrefs.SetInt("USER_STAGE24", UserInformation.Instance.STAGE24_U);
        PlayerPrefs.SetInt("USER_STAGE25", UserInformation.Instance.STAGE25_U);
        PlayerPrefs.SetInt("USER_STAGE26", UserInformation.Instance.STAGE26_U);
        PlayerPrefs.SetInt("USER_STAGE27", UserInformation.Instance.STAGE27_U);
        PlayerPrefs.SetInt("USER_STAGE28", UserInformation.Instance.STAGE28_U);
        PlayerPrefs.SetInt("USER_STAGE29", UserInformation.Instance.STAGE29_U);
        PlayerPrefs.SetInt("USER_STAGE30", UserInformation.Instance.STAGE30_U);

        PlayerPrefs.SetInt("USER_STAGE31", UserInformation.Instance.STAGE31_U);
        PlayerPrefs.SetInt("USER_STAGE32", UserInformation.Instance.STAGE32_U);

        Debug.Log("SAVE User_to_SERVER");

    }
    public static void SavePlayerTOServer()
    {
        PlayerPrefs.SetString("USER_NAME", Player.NewPlayer.playerName);
        PlayerPrefs.SetInt("USER_LEVEL", Player.NewPlayer.playerLevel);
        PlayerPrefs.SetInt("USER_ISFIRST", Player.NewPlayer.IsFirst);
        PlayerPrefs.SetInt("USER_MTYPE", Player.NewPlayer.playerMtype);
        PlayerPrefs.SetInt("USER_SKILLUPPOINT",Player.NewPlayer.PlayerSkillUpPoint);
        PlayerPrefs.SetInt("USER_STYPE", Player.NewPlayer.PlayerSpeciesType);
        PlayerPrefs.SetInt("USER_EXP_C", Player.NewPlayer.Player_MainCurrentEXP);
        PlayerPrefs.SetInt("USER_EXP_MAX", Player.NewPlayer.Player_MainMaxEXP);
        //PlayerPrefs.SetInt("USER_NOWSTAGE", Player.NewPlayer.IsNowStage);
        
        PlayerPrefs.SetInt("USER_STAGE01", Player.NewPlayer.STAGE_01);
        PlayerPrefs.SetInt("USER_STAGE02", Player.NewPlayer.STAGE_02);
        PlayerPrefs.SetInt("USER_STAGE03", Player.NewPlayer.STAGE_03);
        PlayerPrefs.SetInt("USER_STAGE04", Player.NewPlayer.STAGE_04);
        PlayerPrefs.SetInt("USER_STAGE05", Player.NewPlayer.STAGE_05);
        PlayerPrefs.SetInt("USER_STAGE06", Player.NewPlayer.STAGE_06);
        PlayerPrefs.SetInt("USER_STAGE07", Player.NewPlayer.STAGE_07);
        PlayerPrefs.SetInt("USER_STAGE08", Player.NewPlayer.STAGE_08);
        PlayerPrefs.SetInt("USER_STAGE09", Player.NewPlayer.STAGE_09);
        PlayerPrefs.SetInt("USER_STAGE10", Player.NewPlayer.STAGE_10);
                                                                    
        PlayerPrefs.SetInt("USER_STAGE11", Player.NewPlayer.STAGE_11);
        PlayerPrefs.SetInt("USER_STAGE12", Player.NewPlayer.STAGE_12);
        PlayerPrefs.SetInt("USER_STAGE13", Player.NewPlayer.STAGE_13);
        PlayerPrefs.SetInt("USER_STAGE14", Player.NewPlayer.STAGE_14);
        PlayerPrefs.SetInt("USER_STAGE15", Player.NewPlayer.STAGE_15);
        PlayerPrefs.SetInt("USER_STAGE16", Player.NewPlayer.STAGE_16);
        PlayerPrefs.SetInt("USER_STAGE17", Player.NewPlayer.STAGE_17);
        PlayerPrefs.SetInt("USER_STAGE18", Player.NewPlayer.STAGE_18);
        PlayerPrefs.SetInt("USER_STAGE19", Player.NewPlayer.STAGE_19);
        PlayerPrefs.SetInt("USER_STAGE20", Player.NewPlayer.STAGE_20);
                                                                    
        PlayerPrefs.SetInt("USER_STAGE21", Player.NewPlayer.STAGE_21);
        PlayerPrefs.SetInt("USER_STAGE22", Player.NewPlayer.STAGE_22);
        PlayerPrefs.SetInt("USER_STAGE23", Player.NewPlayer.STAGE_23);
        PlayerPrefs.SetInt("USER_STAGE24", Player.NewPlayer.STAGE_24);
        PlayerPrefs.SetInt("USER_STAGE25", Player.NewPlayer.STAGE_25);
        PlayerPrefs.SetInt("USER_STAGE26", Player.NewPlayer.STAGE_26);
        PlayerPrefs.SetInt("USER_STAGE27", Player.NewPlayer.STAGE_27);
        PlayerPrefs.SetInt("USER_STAGE28", Player.NewPlayer.STAGE_28);
        PlayerPrefs.SetInt("USER_STAGE29", Player.NewPlayer.STAGE_29);
        PlayerPrefs.SetInt("USER_STAGE30", Player.NewPlayer.STAGE_30);
                                                                    
        PlayerPrefs.SetInt("USER_STAGE31", Player.NewPlayer.STAGE_31);
        PlayerPrefs.SetInt("USER_STAGE32", Player.NewPlayer.STAGE_32);
        Debug.Log("SAVE Player_to_SERVER");

    }
    public static void SaveDEFALT()
    {
        PlayerPrefs.SetString("USER_NAME", "NONAME");
        PlayerPrefs.SetInt("USER_LEVEL", 0);
        PlayerPrefs.SetInt("USER_ISFIRST", 0);
        PlayerPrefs.SetInt("USER_MTYPE", 0);
        PlayerPrefs.SetInt("USER_SKILLUPPOINT", 0);
        PlayerPrefs.SetInt("USER_STYPE", 0);
        PlayerPrefs.SetInt("USER_EXP_C", 0);
        PlayerPrefs.SetInt("USER_EXP_MAX", PlayerPrefs.GetInt("USER_LEVEL") * 150);
        PlayerPrefs.SetInt("USER_NOWSTAGE", 1);

        PlayerPrefs.SetInt("USER_STAGE01", 0);
        PlayerPrefs.SetInt("USER_STAGE02", 0);
        PlayerPrefs.SetInt("USER_STAGE03", 0);
        PlayerPrefs.SetInt("USER_STAGE04", 0);
        PlayerPrefs.SetInt("USER_STAGE05", 0);
        PlayerPrefs.SetInt("USER_STAGE06", 0);
        PlayerPrefs.SetInt("USER_STAGE07", 0);
        PlayerPrefs.SetInt("USER_STAGE08", 0);
        PlayerPrefs.SetInt("USER_STAGE09", 0);
        PlayerPrefs.SetInt("USER_STAGE10", 0);
                                           
        PlayerPrefs.SetInt("USER_STAGE11", 0);
        PlayerPrefs.SetInt("USER_STAGE12", 0);
        PlayerPrefs.SetInt("USER_STAGE13", 0);
        PlayerPrefs.SetInt("USER_STAGE14", 0);
        PlayerPrefs.SetInt("USER_STAGE15", 0);
        PlayerPrefs.SetInt("USER_STAGE16", 0);
        PlayerPrefs.SetInt("USER_STAGE17", 0);
        PlayerPrefs.SetInt("USER_STAGE18", 0);
        PlayerPrefs.SetInt("USER_STAGE19", 0);
        PlayerPrefs.SetInt("USER_STAGE20", 0);
                                           
        PlayerPrefs.SetInt("USER_STAGE21", 0);
        PlayerPrefs.SetInt("USER_STAGE22", 0);
        PlayerPrefs.SetInt("USER_STAGE23", 0);
        PlayerPrefs.SetInt("USER_STAGE24", 0);
        PlayerPrefs.SetInt("USER_STAGE25", 0);
        PlayerPrefs.SetInt("USER_STAGE26", 0);
        PlayerPrefs.SetInt("USER_STAGE27", 0);
        PlayerPrefs.SetInt("USER_STAGE28", 0);
        PlayerPrefs.SetInt("USER_STAGE29", 0);
        PlayerPrefs.SetInt("USER_STAGE30", 0);
                                           
        PlayerPrefs.SetInt("USER_STAGE31", 0);
        PlayerPrefs.SetInt("USER_STAGE32", 0);

        Debug.Log("SAVE DEFALUT");

    }
    public static void SaveMAXLEVEL()
    {
        PlayerPrefs.SetString("USER_NAME", "MAXMAN");
        PlayerPrefs.SetInt("USER_LEVEL", 30);
        PlayerPrefs.SetInt("USER_ISFIRST", 1);
        PlayerPrefs.SetInt("USER_MTYPE", 100);
        PlayerPrefs.SetInt("USER_SKILLUPPOINT", 30);
        PlayerPrefs.SetInt("USER_STYPE", 1);
        PlayerPrefs.SetInt("USER_EXP_C", 0);
        PlayerPrefs.SetInt("USER_EXP_MAX", PlayerPrefs.GetInt("USER_LEVEL") * 150);
        PlayerPrefs.SetInt("USER_NOWSTAGE", 32);

        PlayerPrefs.SetInt("USER_STAGE01", 1);
        PlayerPrefs.SetInt("USER_STAGE02", 1);
        PlayerPrefs.SetInt("USER_STAGE03", 0);
        PlayerPrefs.SetInt("USER_STAGE04", 1);
        PlayerPrefs.SetInt("USER_STAGE05", 1);
        PlayerPrefs.SetInt("USER_STAGE06", 1);
        PlayerPrefs.SetInt("USER_STAGE07", 1);
        PlayerPrefs.SetInt("USER_STAGE08", 1);
        PlayerPrefs.SetInt("USER_STAGE09", 1);
        PlayerPrefs.SetInt("USER_STAGE10", 1);
                                           
        PlayerPrefs.SetInt("USER_STAGE11", 1);
        PlayerPrefs.SetInt("USER_STAGE12", 1);
        PlayerPrefs.SetInt("USER_STAGE13", 1);
        PlayerPrefs.SetInt("USER_STAGE14", 1);
        PlayerPrefs.SetInt("USER_STAGE15", 1);
        PlayerPrefs.SetInt("USER_STAGE16", 1);
        PlayerPrefs.SetInt("USER_STAGE17", 1);
        PlayerPrefs.SetInt("USER_STAGE18", 1);
        PlayerPrefs.SetInt("USER_STAGE19", 1);
        PlayerPrefs.SetInt("USER_STAGE20", 1);
                                           
        PlayerPrefs.SetInt("USER_STAGE21", 1);
        PlayerPrefs.SetInt("USER_STAGE22", 1);
        PlayerPrefs.SetInt("USER_STAGE23", 1);
        PlayerPrefs.SetInt("USER_STAGE24", 1);
        PlayerPrefs.SetInt("USER_STAGE25", 1);
        PlayerPrefs.SetInt("USER_STAGE26", 1);
        PlayerPrefs.SetInt("USER_STAGE27", 1);
        PlayerPrefs.SetInt("USER_STAGE28", 1);
        PlayerPrefs.SetInt("USER_STAGE29", 1);
        PlayerPrefs.SetInt("USER_STAGE30", 1);
                                           
        PlayerPrefs.SetInt("USER_STAGE31", 1);
        PlayerPrefs.SetInt("USER_STAGE32", 1);

        Debug.Log("SAVE MAX");

    }

}
