using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillUI_Open : MonoBehaviour {

    Button b_100_A;
    Button b_110_A;
    Button b_111_A;
    Button b_112_A;
    Button b_113_A;
    Button b_120_A;
    Button b_121_A;
    Button b_122_A;
    Button b_123_A;

    Button b_100_B;
    Button b_110_B;
    Button b_111_B;
    Button b_112_B;
    Button b_113_B;
    Button b_120_B;
    Button b_121_B;
    Button b_122_B;
    Button b_123_B;

    Button b_Lvup_01;
    Button b_Lvup_02;
    Button b_Lvup_03;

    IG_MainPlayer P;
    // Use this for initialization
    void Start () {
        P = GameObject.FindGameObjectWithTag("Cha").GetComponent<IG_MainPlayer>();

        b_100_A = transform.GetChild(0).GetComponent<Button>();
        b_110_A = transform.GetChild(1).GetComponent<Button>();
        b_111_A = transform.GetChild(2).GetComponent<Button>();
        b_112_A = transform.GetChild(3).GetComponent<Button>();
        b_113_A = transform.GetChild(4).GetComponent<Button>();
        b_120_A = transform.GetChild(5).GetComponent<Button>();
        b_121_A = transform.GetChild(6).GetComponent<Button>();
        b_122_A = transform.GetChild(7).GetComponent<Button>();
        b_123_A = transform.GetChild(8).GetComponent<Button>();

        b_100_B = transform.GetChild(9).GetComponent<Button>();
        b_110_B = transform.GetChild(10).GetComponent<Button>();
        b_111_B = transform.GetChild(11).GetComponent<Button>();
        b_112_B = transform.GetChild(12).GetComponent<Button>();
        b_113_B = transform.GetChild(13).GetComponent<Button>();
        b_120_B = transform.GetChild(14).GetComponent<Button>();
        b_121_B = transform.GetChild(15).GetComponent<Button>();
        b_122_B = transform.GetChild(16).GetComponent<Button>();
        b_123_B = transform.GetChild(17).GetComponent<Button>();

        if (Player.NewPlayer.playerMtype != 0)
        {
            b_Lvup_01 = transform.GetChild(18).GetComponent<Button>();
        }
        if (Player.NewPlayer.playerMtype != 0 && Player.NewPlayer.playerMtype != 100)
        {
            b_Lvup_02 = transform.GetChild(19).GetComponent<Button>();
        }
        if (Player.NewPlayer.playerMtype != 0 && Player.NewPlayer.playerMtype != 100 && Player.NewPlayer.playerMtype != 110 && Player.NewPlayer.playerMtype != 120)
        {
            b_Lvup_03 = transform.GetChild(20).GetComponent<Button>();
        }
            

        b_100_A.interactable = false;
        b_111_A.interactable = false;
        b_112_A.interactable = false;
        b_113_A.interactable = false;
        b_120_A.interactable = false;
        b_121_A.interactable = false;
        b_122_A.interactable = false;
        b_123_A.interactable = false;

        b_100_B.interactable = false;
        b_111_B.interactable = false;
        b_112_B.interactable = false;
        b_113_B.interactable = false;
        b_120_B.interactable = false;
        b_121_B.interactable = false;
        b_122_B.interactable = false;
        b_123_B.interactable = false;
    }

    private void Update()
    {
        if (Player.NewPlayer.Resources >= transform.parent.parent.GetComponent<IG_MainPlayer>().S_100_Defence_Gold && P.bDF_100_SCool_Ing == false)
        {
            b_100_B.interactable = true;
        }
        else
            b_100_B.interactable = false;
            

        if (Player.NewPlayer.Resources >= transform.parent.parent.GetComponent<IG_MainPlayer>().S_110_Defence_Gold && P.bDF_110_SCool_Ing == false)
        {
            b_110_B.interactable = true;
        }
        else
            b_110_B.interactable = false;

        if (Player.NewPlayer.Resources >= transform.parent.parent.GetComponent<IG_MainPlayer>().S_111_Defence_Gold)
        {
            b_111_B.interactable = true;
        }
        else
            b_111_B.interactable = false;

        if (Player.NewPlayer.Resources >= transform.parent.parent.GetComponent<IG_MainPlayer>().S_112_Defence_Gold)
        {
            b_112_B.interactable = true;
        }
        else
            b_112_B.interactable = false;

        if (Player.NewPlayer.Resources >= transform.parent.parent.GetComponent<IG_MainPlayer>().S_113_Defence_Gold)
        {
            b_113_B.interactable = true;
        }
        else
            b_113_B.interactable = false;

        if (Player.NewPlayer.Resources >= transform.parent.parent.GetComponent<IG_MainPlayer>().S_120_Defence_Gold)
        {
            b_120_B.interactable = true;
        }
        else
            b_120_B.interactable = false;

        if (Player.NewPlayer.Resources >= transform.parent.parent.GetComponent<IG_MainPlayer>().S_121_Defence_Gold)
        {
            b_121_B.interactable = true;
        }
        else
            b_121_B.interactable = false;

        if (Player.NewPlayer.Resources >= transform.parent.parent.GetComponent<IG_MainPlayer>().S_122_Defence_Gold)
        {
            b_122_B.interactable = true;
        }
        else
            b_122_B.interactable = false;

        if (Player.NewPlayer.Resources >= transform.parent.parent.GetComponent<IG_MainPlayer>().S_123_Defence_Gold)
        {
            b_123_B.interactable = true;
        }
        else
            b_123_B.interactable = false;

    }

    public void Skill_LvUP_First()
    {
        if(Player.NewPlayer.IsATKDEF_12 == 1 && Player.NewPlayer.playerMtype != 0 )
            Skill_100_Active();
    }

    public void Skill_LvUP_Second()
    {
        if (Player.NewPlayer.IsATKDEF_12 == 1 && Player.NewPlayer.playerMtype == 110 | Player.NewPlayer.playerMtype == 111 | Player.NewPlayer.playerMtype == 112 | Player.NewPlayer.playerMtype == 113)
            Skill_110_Active();
        else if (Player.NewPlayer.IsATKDEF_12 == 1 && Player.NewPlayer.playerMtype == 120 | Player.NewPlayer.playerMtype == 121 | Player.NewPlayer.playerMtype == 122 | Player.NewPlayer.playerMtype == 123)
            Skill_120_Active();
    }

    public void Skill_LvUP_Third()
    {
        if (Player.NewPlayer.IsATKDEF_12 == 1 && Player.NewPlayer.playerMtype == 111)        
            Skill_111_Active();        
        else if (Player.NewPlayer.IsATKDEF_12 == 1 && Player.NewPlayer.playerMtype == 112)
            Skill_112_Active();
        else if (Player.NewPlayer.IsATKDEF_12 == 1 && Player.NewPlayer.playerMtype == 113)
            Skill_113_Active();
        else if (Player.NewPlayer.IsATKDEF_12 == 1 && Player.NewPlayer.playerMtype == 121)
            Skill_121_Active();
        else if (Player.NewPlayer.IsATKDEF_12 == 1 && Player.NewPlayer.playerMtype == 122)
            Skill_122_Active();
        else if (Player.NewPlayer.IsATKDEF_12 == 1 && Player.NewPlayer.playerMtype == 123)
            Skill_123_Active();
    }

    private void Skill_100_Active()
    {   
         b_100_A.interactable = true;
         IG_MainPlayer.LVUP_Point -= 1;       

        
        if (IG_MainPlayer.LVUP_Point == 0)
        {
            if (Player.NewPlayer.playerMtype == 100)
                b_Lvup_01.gameObject.SetActive(false);
            if (Player.NewPlayer.playerMtype == 110 | Player.NewPlayer.playerMtype == 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
            }
            if (Player.NewPlayer.playerMtype != 100 && Player.NewPlayer.playerMtype != 110 && Player.NewPlayer.playerMtype != 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
                b_Lvup_03.gameObject.SetActive(false);
            }
        }
    }
    private void Skill_110_Active()
    {
        b_110_A.interactable = true;
        IG_MainPlayer.LVUP_Point -= 1;

        if (IG_MainPlayer.LVUP_Point == 0)
        {
            if (Player.NewPlayer.playerMtype == 100)
                b_Lvup_01.gameObject.SetActive(false);

            if (Player.NewPlayer.playerMtype == 110 | Player.NewPlayer.playerMtype == 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
            }
            if (Player.NewPlayer.playerMtype != 100 && Player.NewPlayer.playerMtype != 110 && Player.NewPlayer.playerMtype != 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
                b_Lvup_03.gameObject.SetActive(false);
            }
        }
    }
    private void Skill_111_Active()
    {
        b_111_A.interactable = true;
        IG_MainPlayer.LVUP_Point -= 1;

        if (IG_MainPlayer.LVUP_Point == 0)
        {
            if (Player.NewPlayer.playerMtype == 100)
                b_Lvup_01.gameObject.SetActive(false);
            if (Player.NewPlayer.playerMtype == 110 | Player.NewPlayer.playerMtype == 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
            }
            if (Player.NewPlayer.playerMtype != 100 && Player.NewPlayer.playerMtype != 110 && Player.NewPlayer.playerMtype != 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
                b_Lvup_03.gameObject.SetActive(false);
            }
        }
    }
    private void Skill_112_Active()
    {
        b_112_A.interactable = true;
        IG_MainPlayer.LVUP_Point -= 1;

        if (IG_MainPlayer.LVUP_Point == 0)
        {
            if (Player.NewPlayer.playerMtype == 100)
                b_Lvup_01.gameObject.SetActive(false);
            if (Player.NewPlayer.playerMtype == 110 | Player.NewPlayer.playerMtype == 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
            }
            if (Player.NewPlayer.playerMtype != 100 && Player.NewPlayer.playerMtype != 110 && Player.NewPlayer.playerMtype != 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
                b_Lvup_03.gameObject.SetActive(false);
            }
        }
    }
    private void Skill_113_Active()
    {
        b_113_A.interactable = true;
        IG_MainPlayer.LVUP_Point -= 1;

        if (IG_MainPlayer.LVUP_Point == 0)
        {
            if (Player.NewPlayer.playerMtype == 100)
                b_Lvup_01.gameObject.SetActive(false);
            if (Player.NewPlayer.playerMtype == 110 | Player.NewPlayer.playerMtype == 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
            }
            if (Player.NewPlayer.playerMtype != 100 && Player.NewPlayer.playerMtype != 110 && Player.NewPlayer.playerMtype != 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
                b_Lvup_03.gameObject.SetActive(false);
            }
        }
    }

    private void Skill_120_Active()
    {
        b_120_A.interactable = true;
        IG_MainPlayer.LVUP_Point -= 1;

        if (IG_MainPlayer.LVUP_Point == 0)
        {
            if(Player.NewPlayer.playerMtype == 100)
                b_Lvup_01.gameObject.SetActive(false);
            if(Player.NewPlayer.playerMtype == 110 | Player.NewPlayer.playerMtype == 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
            }
            if(Player.NewPlayer.playerMtype != 100 && Player.NewPlayer.playerMtype != 110 && Player.NewPlayer.playerMtype != 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
                b_Lvup_03.gameObject.SetActive(false);
            }            
        }
    }
    private void Skill_121_Active()
    {
        b_121_A.interactable = true;
        IG_MainPlayer.LVUP_Point -= 1;

        if (IG_MainPlayer.LVUP_Point == 0)
        {
            if (Player.NewPlayer.playerMtype == 100)
                b_Lvup_01.gameObject.SetActive(false);
            if (Player.NewPlayer.playerMtype == 110 | Player.NewPlayer.playerMtype == 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
            }
            if (Player.NewPlayer.playerMtype != 100 && Player.NewPlayer.playerMtype != 110 && Player.NewPlayer.playerMtype != 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
                b_Lvup_03.gameObject.SetActive(false);
            }
        }
    }
    private void Skill_122_Active()
    {
        b_122_A.interactable = true;
        IG_MainPlayer.LVUP_Point -= 1;

        if (IG_MainPlayer.LVUP_Point == 0)
        {
            if (Player.NewPlayer.playerMtype == 100)
                b_Lvup_01.gameObject.SetActive(false);
            if (Player.NewPlayer.playerMtype == 110 | Player.NewPlayer.playerMtype == 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
            }
            if (Player.NewPlayer.playerMtype != 100 && Player.NewPlayer.playerMtype != 110 && Player.NewPlayer.playerMtype != 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
                b_Lvup_03.gameObject.SetActive(false);
            }
        }
    }
    private void Skill_123_Active()
    {
        b_123_A.interactable = true;
        IG_MainPlayer.LVUP_Point -= 1;

        if (IG_MainPlayer.LVUP_Point == 0)
        {
            if (Player.NewPlayer.playerMtype == 100)
                b_Lvup_01.gameObject.SetActive(false);
            if (Player.NewPlayer.playerMtype == 110 | Player.NewPlayer.playerMtype == 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
            }
            if (Player.NewPlayer.playerMtype != 100 && Player.NewPlayer.playerMtype != 110 && Player.NewPlayer.playerMtype != 120)
            {
                b_Lvup_01.gameObject.SetActive(false);
                b_Lvup_02.gameObject.SetActive(false);
                b_Lvup_03.gameObject.SetActive(false);
            }
        }
    }

    

    // Update is called once per frame
    public void SkillSetting () {
        if(Player.NewPlayer.playerMtype == 100 && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            
        }
        if (Player.NewPlayer.playerMtype == 110 && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 111 && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 112 && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 113 && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(4).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 120 && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(5).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 121 && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(5).gameObject.SetActive(true);
            transform.GetChild(6).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 122 && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(5).gameObject.SetActive(true);
            transform.GetChild(7).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 123 && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(5).gameObject.SetActive(true);
            transform.GetChild(8).gameObject.SetActive(true);
        }

        //-----def

        if (Player.NewPlayer.playerMtype == 100 && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            transform.GetChild(9).gameObject.SetActive(true);

        }
        if (Player.NewPlayer.playerMtype == 110 && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            transform.GetChild(9).gameObject.SetActive(true);
            transform.GetChild(10).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 111 && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            transform.GetChild(9).gameObject.SetActive(true);
            transform.GetChild(10).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 112 && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            transform.GetChild(9).gameObject.SetActive(true);
            transform.GetChild(10).gameObject.SetActive(true);
            transform.GetChild(12).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 113 && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            transform.GetChild(9).gameObject.SetActive(true);
            transform.GetChild(10).gameObject.SetActive(true);
            transform.GetChild(13).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 120 && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            transform.GetChild(9).gameObject.SetActive(true);
            transform.GetChild(14).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 121 && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            transform.GetChild(9).gameObject.SetActive(true);
            transform.GetChild(14).gameObject.SetActive(true);
            transform.GetChild(15).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 122 && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            transform.GetChild(9).gameObject.SetActive(true);
            transform.GetChild(14).gameObject.SetActive(true);
            transform.GetChild(16).gameObject.SetActive(true);
        }
        if (Player.NewPlayer.playerMtype == 123 && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            transform.GetChild(9).gameObject.SetActive(true);
            transform.GetChild(14).gameObject.SetActive(true);
            transform.GetChild(17).gameObject.SetActive(true);
        }
    }
}
