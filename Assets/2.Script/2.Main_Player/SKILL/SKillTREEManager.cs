using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SKillTREEManager : MonoBehaviour {
    Player playerModelLoad;

    GameObject creater_100;

    GameObject creater_110;
    GameObject creater_120;

    GameObject creater_111;
    GameObject creater_112;
    GameObject creater_113;

    GameObject creater_121;
    GameObject creater_122;
    GameObject creater_123;
    
    static int open_close_100 = 0;

    static int open_close_110 = 0;
    static int open_close_120 = 0;

    static int open_close_111 = 0;
    static int open_close_112 = 0;
    static int open_close_113 = 0;

    static int open_close_121 = 0;
    static int open_close_122 = 0;
    static int open_close_123 = 0;
    // Use this for initialization

    void Start () {
        
        playerModelLoad = GameObject.Find("SelectRobbyManager").GetComponent<Player>();
       // DontDestroyOnLoad(this.gameObject);
        

        creater_100 = transform.GetChild(0).GetChild(0).gameObject;

        creater_110 = transform.GetChild(0).GetChild(1).gameObject;
                                                        
        creater_111 = transform.GetChild(0).GetChild(2).gameObject;
        creater_112 = transform.GetChild(0).GetChild(3).gameObject;
        creater_113 = transform.GetChild(0).GetChild(4).gameObject;
                             
        creater_120 = transform.GetChild(0).GetChild(5).gameObject;
                             
        creater_121 = transform.GetChild(0).GetChild(6).gameObject;
        creater_122 = transform.GetChild(0).GetChild(7).gameObject;
        creater_123 = transform.GetChild(0).GetChild(8).gameObject;
        StartCheck();

    }

   /* public void ClickButton_OPEN()
    {
        if (Player.NewPlayer.PlayerSkillUpPoint == 0)
        {
            creater_100.SetActive(false);
            //creater_200.SetActive(true);
        }
        else
            creater_100.SetActive(true);
    }*/
    public void StartCheck()
    {
        if (Player.NewPlayer.playerMtype == 0)
        {
            creater_100.SetActive(true);
            creater_110.SetActive(false);
            creater_120.SetActive(false);

        }

        else if(Player.NewPlayer.playerMtype == 100)
        {
            open_close_100 = 1;

            creater_100.SetActive(true);

            creater_110.SetActive(true);
            creater_120.SetActive(true);
            
        }
        else if(Player.NewPlayer.playerMtype == 110)
        {
            open_close_100 = 1;
            open_close_110 = 1;

            creater_100.SetActive(true);
            creater_110.SetActive(true);
            
            creater_111.SetActive(true);
            creater_112.SetActive(true);
            creater_113.SetActive(true);
            
        }
        else if (Player.NewPlayer.playerMtype == 111)
        {
            open_close_100 = 1;
            open_close_110 = 1;
            open_close_111 = 1;

            creater_100.SetActive(true);
            creater_110.SetActive(true);

            creater_111.SetActive(true);
            creater_112.SetActive(false);
            creater_113.SetActive(false);
            
            
        }
        else if (Player.NewPlayer.playerMtype == 112)
        {
            open_close_100 = 1;
            open_close_110 = 1;
            open_close_112 = 1;

            creater_100.SetActive(true);
            creater_110.SetActive(true);

            creater_111.SetActive(false);
            creater_112.SetActive(true);
            creater_113.SetActive(false);
        }
        else if (Player.NewPlayer.playerMtype == 113)
        {
            open_close_100 = 1;
            open_close_110 = 1;
            open_close_113 = 1;

            creater_100.SetActive(true);
            creater_110.SetActive(true);

            creater_111.SetActive(false);
            creater_112.SetActive(false);
            creater_113.SetActive(true);
        }
        else if (Player.NewPlayer.playerMtype == 120)
        {
            open_close_100 = 1;
            open_close_120 = 1;

            creater_100.SetActive(true);
            creater_120.SetActive(true);

            creater_121.SetActive(true);
            creater_122.SetActive(true);
            creater_123.SetActive(true);
       
        }
        else if (Player.NewPlayer.playerMtype == 121)
        {
            open_close_100 = 1;
            open_close_120 = 1;
            open_close_121 = 1;

            creater_100.SetActive(true);
            creater_120.SetActive(true);

            creater_121.SetActive(true);
            creater_122.SetActive(false);
            creater_123.SetActive(false);
        }
        else if (Player.NewPlayer.playerMtype == 122)
        {
            open_close_100 = 1;
            open_close_120 = 1;
            open_close_122 = 1;

            creater_100.SetActive(true);
            creater_120.SetActive(true);

            creater_121.SetActive(false);
            creater_122.SetActive(true);
            creater_123.SetActive(false);
        }
        else if (Player.NewPlayer.playerMtype == 123)
        {
            open_close_100 = 1;
            open_close_120 = 1;
            open_close_123 = 1;

            creater_100.SetActive(true);
            creater_120.SetActive(true);

            creater_121.SetActive(false);
            creater_122.SetActive(false);
            creater_123.SetActive(true);
        }
    }


	public void ClickButton_100()
    {
        
        if (Player.NewPlayer.PlayerSkillUpPoint >0 && open_close_100 == 0)
        {
            Player.NewPlayer.playerMtype = 100;

            //Player.NewPlayer.AppearFirstLv = 1;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint -= 1;
            creater_110.SetActive(true);
            creater_120.SetActive(true);
            open_close_100 = 1;
        }
        else if(open_close_100 == 1 && open_close_110 == 0 && open_close_120 == 0 && open_close_111 == 0 && open_close_112 == 0 && open_close_113 == 0 && open_close_121 == 0 && open_close_122 == 0 && open_close_123 == 0)
        {
            Player.NewPlayer.playerMtype = 0;

            //Player.NewPlayer.AppearFirstLv = 0;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint += 1;
            creater_110.SetActive(false);
            creater_120.SetActive(false);
            open_close_100 = 0;
        }
        
        //creater_200 false
        //creater_300 false
        
    }
    public void ClickButton_110()
    {
        if (Player.NewPlayer.PlayerSkillUpPoint > 0 && open_close_110 == 0)
        {
            Player.NewPlayer.playerMtype = 110;
            Player.NewPlayer.PlayerSkillUpPoint -= 1;

            creater_120.SetActive(false);
            creater_111.SetActive(true);
            creater_112.SetActive(true);
            creater_113.SetActive(true);
            open_close_110 = 1;
        }
        else if (open_close_110 == 1 && open_close_111 == 0 && open_close_112 ==0 && open_close_113 ==0)
        {
            Player.NewPlayer.playerMtype = 100;
            //Player.NewPlayer.AppearSecondLv = 0;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint += 1;

            creater_120.SetActive(true);
            creater_111.SetActive(false);
            creater_112.SetActive(false);
            creater_113.SetActive(false);
            open_close_110 = 0;
        }


    }
    public void ClickButton_111()
    {
        if (Player.NewPlayer.PlayerSkillUpPoint > 0 && open_close_111 == 0)
        {
            Player.NewPlayer.playerMtype = 111;
           // Player.NewPlayer.AppearThirdLv = 1;
           // Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint -= 1;

            creater_112.SetActive(false);
            creater_113.SetActive(false);
            open_close_111 = 1;
        }

        else if(open_close_111 == 1)
        {
            Player.NewPlayer.playerMtype = 110;
            //Player.NewPlayer.AppearThirdLv = 0;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint += 1;

            creater_112.SetActive(true);
            creater_113.SetActive(true);
            open_close_111 = 0;
        }
    }

    public void ClickButton_112()
    {
        if (Player.NewPlayer.PlayerSkillUpPoint > 0 && open_close_112 == 0)
        {
            Player.NewPlayer.playerMtype = 112;

            //Player.NewPlayer.AppearThirdLv = 2;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint -= 1;

            creater_111.SetActive(false);
            creater_113.SetActive(false);
            open_close_112 = 1;
        }


        else if(open_close_112 == 1)
        {
            Player.NewPlayer.playerMtype = 110;

            //Player.NewPlayer.AppearThirdLv = 0;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint += 1;

            creater_111.SetActive(true);
            creater_113.SetActive(true);
            open_close_112 = 0;

        }
    }
    public void ClickButton_113()
    {
        if (Player.NewPlayer.PlayerSkillUpPoint > 0 && open_close_113 == 0)
        {
            Player.NewPlayer.playerMtype = 113;

            //Player.NewPlayer.AppearThirdLv = 3;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint -= 1;

            creater_111.SetActive(false);
            creater_112.SetActive(false);
            open_close_113 = 1;
        }


        else if(open_close_113 == 1)
        {
            Player.NewPlayer.playerMtype = 110;

            //Player.NewPlayer.AppearThirdLv = 0;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint += 1;

            creater_111.SetActive(true);
            creater_112.SetActive(true);
            open_close_113 = 0;
        }
    }
    public void ClickButton_120()
    {
        if (Player.NewPlayer.PlayerSkillUpPoint > 0 && open_close_120 == 0)
        {
            Player.NewPlayer.playerMtype = 120;
            //Player.NewPlayer.AppearSecondLv = 2;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint -= 1;

            creater_110.SetActive(false);
            creater_121.SetActive(true);
            creater_122.SetActive(true);
            creater_123.SetActive(true);
            open_close_120 = 1;
        }

        else if(open_close_120 == 1 && open_close_121 == 0 && open_close_122 == 0 && open_close_123 == 0)
        {
            Player.NewPlayer.playerMtype = 100;
            //Player.NewPlayer.AppearSecondLv = 0;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint += 1;

            creater_110.SetActive(true);
            creater_121.SetActive(false);
            creater_122.SetActive(false);
            creater_123.SetActive(false);
            open_close_120 = 0;
        }
    }
    public void ClickButton_121()
    {
        if (Player.NewPlayer.PlayerSkillUpPoint > 0 && open_close_121 == 0)
        {
            Player.NewPlayer.playerMtype = 121;
            //Player.NewPlayer.AppearThirdLv = 1;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint -= 1;

            creater_122.SetActive(false);
            creater_123.SetActive(false);
            open_close_121 = 1;
        }


        else if(open_close_121 == 1)
        {
            Player.NewPlayer.playerMtype = 121;
            //Player.NewPlayer.AppearThirdLv = 0;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint += 1;

            creater_122.SetActive(true);
            creater_123.SetActive(true);
            open_close_121 = 0;
        }
    }
    public void ClickButton_122()
    {
        if (Player.NewPlayer.PlayerSkillUpPoint > 0 && open_close_122 == 0)
        {
            Player.NewPlayer.playerMtype = 122;
            //Player.NewPlayer.AppearThirdLv = 2;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint -= 1;

            creater_121.SetActive(false);
            creater_123.SetActive(false);
            open_close_122 = 1;
        }


        else if(open_close_122 == 1)
        {
            Player.NewPlayer.playerMtype = 120;
            //Player.NewPlayer.AppearThirdLv = 0;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint += 1;

            creater_121.SetActive(true);
            creater_123.SetActive(true);
            open_close_122 = 0;
        }
    }

    public void ClickButton_123()
    {
        if (Player.NewPlayer.PlayerSkillUpPoint > 0 && open_close_123 == 0)
        {
            Player.NewPlayer.playerMtype = 123;
            //Player.NewPlayer.AppearThirdLv = 3;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint -= 1;

            creater_121.SetActive(false);
            creater_122.SetActive(false);
            open_close_123 = 1;
        }


        else if(open_close_123 == 1)
        {
            Player.NewPlayer.playerMtype = 120;
            //Player.NewPlayer.AppearThirdLv = 0;
            //Player.NewPlayer.SAVE_Jobskill_toPlayerState();
            Player.NewPlayer.PlayerSkillUpPoint += 1;

            creater_121.SetActive(true);
            creater_122.SetActive(true);
            open_close_123 = 0;
        }
    }

    public void ClickButton_SaveSkill_To_UserInformation_Instance()
    { 
        SaveUserInformation.SavePlayerToUserInformation();
        Debug.Log("SAVE COMPLETE  : " + UserInformation.Instance.MODELTYPE);
        SaveUserInformation.SaveUserInformationTOServer();


        Destroy(Player.MODEL);
        playerModelLoad.MakeModel();
        InforSL_Manager.ResizeInGameModelPosition();
        
        

    }
    
    /*public void MakeModel()
    {
        if (Player.NewPlayer.playerMtype == 0)
        {
            Player.MODEL = Instantiate(Model_baseSAC);
            DontDestroyOnLoad(Player.MODEL);
        }
        if (Player.NewPlayer.playerMtype == 100)
        {
            Player.MODEL = Instantiate(Model_baseSAC);
            DontDestroyOnLoad(Player.MODEL);
        }
        else if (Player.NewPlayer.playerMtype == 200)
        {
            Player.MODEL = Instantiate(Model_Robot);
            DontDestroyOnLoad(Player.MODEL);
        }
    }*/

}
