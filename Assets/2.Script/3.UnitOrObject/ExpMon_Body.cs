using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpMon_Body : MonoBehaviour {

    
    HUD_Add_BF_ExpMon Parent;

    // Use this for initialization
    void Start () {
        
        Parent = transform.parent.GetComponent<HUD_Add_BF_ExpMon>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mon_Atk")
        {
            StartCoroutine(GameInformation.SYS_MSG2("적이 몬스터를 사냥중입니다", 3f));
            Parent.HP -= 1;
            //StartCoroutine(BF_HUD_Manager.Draw_DMG_EXPMON(1));
            Parent.anim.SetTrigger("IsDmgTrg");

            Parent.Msg_UI.Open_ExpMon();
            Parent.Msg_UI.ExpMon_msg.text = Parent.HP.ToString();


            if (Parent.HP <= 1 && Parent.IsDie == false)
            {
                Parent.AI.EnemyObj.CurrentEXP += Parent.ranEXP;
                //StartCoroutine(BF_HUD_Manager.Draw_DMG_EXPMON(ranEXP));
                Parent.IsDie = true;
            }
            StartCoroutine(Parent.coolTimeOff_ExpMon());
        }

        if (other.gameObject.tag == "Cha_Atk")
        {
            Parent.HP -= 1;
            Parent.anim.SetTrigger("IsDmgTrg");

            if (Player.NewPlayer.IsATKDEF_12 == 1 && Parent.HP >= 1)
            {
                Parent.Msg_UI.Open_ExpMon();
                Parent.Msg_UI.ExpMon_msg.text = Parent.HP.ToString();

                if (Parent.HP <= 1 && Parent.IsDie == false)
                {
                    GetComponent<Collider>().enabled = false;
                    Player.NewPlayer.CurrentEXP += Parent.ranEXP;
                    BF_UICenter.Draw_Msg_MoveUp("+ " + Parent.ranEXP.ToString() + " 경험치를 획득하였습니다");
                    //StartCoroutine(BF_HUD_Manager.Draw_DMG_EXPMON(ranEXP));
                    Parent.IsDie = true;

                }
                StartCoroutine(Parent.coolTimeOff_ExpMon());
            }

            //StartCoroutine(BF_HUD_Manager.Draw_DMG_EXPMON(1));


            if (Player.NewPlayer.IsATKDEF_12 == 2 && Parent.HP >= 1)
            {

                Parent.Msg_UI.Open_GoldMon();
                Parent.Msg_UI.GoldMon_msg.text = Parent.HP.ToString();
                if (Parent.HP <= 1 && Parent.IsDie == false)
                {
                    Player.NewPlayer.Resources += Parent.ranEXP;
                    BF_UICenter.Draw_Msg_MoveUp("+ " + Parent.ranEXP.ToString() + " 골드를 획득하였습니다");
                    //StartCoroutine(BF_HUD_Manager.Draw_DMG_EXPMON(ranEXP));
                    Parent.IsDie = true;
                }
                StartCoroutine(Parent.coolTimeOff_Gold());
            }
        }

        if (other.gameObject.tag == "Skill_100")
        {
            Parent.HP -= (uint)Parent.Reduce_Amount_Skill_100;

            Parent.Msg_UI.Open_ExpMon();
            Parent.Msg_UI.ExpMon_msg.text = Parent.HP.ToString();


            if (Parent.HP <= 1)
            {
                GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().target = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().TargetDefult;
                Destroy(this.gameObject);
                Parent.Msg_UI.Close_ExpMon();
                Parent.Msg_UI.ExpMon_msg.text = "";
            }
        }

        if (other.gameObject.tag == "Skill_110")
        {
            Parent.HP -= (uint)Parent.Reduce_Amount_Skill_110;

            Parent.Msg_UI.Open_ExpMon();
            Parent.Msg_UI.ExpMon_msg.text = Parent.HP.ToString();


            if (Parent.HP <= 1)
            {
                GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().target = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().TargetDefult;
                Destroy(this.gameObject);
                Parent.Msg_UI.Close_ExpMon();
                Parent.Msg_UI.ExpMon_msg.text = "";
            }
        }

        if (other.gameObject.tag == "Skill_111")
        {
            Parent.HP -= (uint)Parent.Reduce_Amount_Skill_111;

            Parent.Msg_UI.Open_ExpMon();
            Parent.Msg_UI.ExpMon_msg.text = Parent.HP.ToString();


            if (Parent.HP <= 1)
            {
                GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().target = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().TargetDefult;
                Destroy(this.gameObject);
                Parent.Msg_UI.Close_ExpMon();
                Parent.Msg_UI.ExpMon_msg.text = "";
            }
        }

        if (other.gameObject.tag == "Skill_112")
        {
            Parent.HP -= (uint)Parent.Reduce_Amount_Skill_112;

            Parent.Msg_UI.Open_ExpMon();
            Parent.Msg_UI.ExpMon_msg.text = Parent.HP.ToString();


            if (Parent.HP <= 1)
            {
                GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().target = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().TargetDefult;
                Destroy(this.gameObject);
                Parent.Msg_UI.Close_ExpMon();
                Parent.Msg_UI.ExpMon_msg.text = "";
            }
        }

        if (other.gameObject.tag == "Skill_113")
        {
            Parent.HP -= (uint)Parent.Reduce_Amount_Skill_113;

            Parent.Msg_UI.Open_ExpMon();
            Parent.Msg_UI.ExpMon_msg.text = Parent.HP.ToString();


            if (Parent.HP <= 1)
            {
                GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().target = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().TargetDefult;
                Destroy(this.gameObject);
                Parent.Msg_UI.Close_ExpMon();
                Parent.Msg_UI.ExpMon_msg.text = "";
            }
        }

        if (other.gameObject.tag == "Skill_120")
        {
            Parent.HP -= (uint)Parent.Reduce_Amount_Skill_120;

            Parent.Msg_UI.Open_ExpMon();
            Parent.Msg_UI.ExpMon_msg.text = Parent.HP.ToString();


            if (Parent.HP <= 1)
            {
                GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().target = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().TargetDefult;
                Destroy(this.gameObject);
                Parent.Msg_UI.Close_ExpMon();
                Parent.Msg_UI.ExpMon_msg.text = "";
            }
        }

        if (other.gameObject.tag == "Skill_121")
        {
            Parent.HP -= (uint)Parent.Reduce_Amount_Skill_121;

            Parent.Msg_UI.Open_ExpMon();
            Parent.Msg_UI.ExpMon_msg.text = Parent.HP.ToString();


            if (Parent.HP <= 1)
            {
                GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().target = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().TargetDefult;
                Destroy(this.gameObject);
                Parent.Msg_UI.Close_ExpMon();
                Parent.Msg_UI.ExpMon_msg.text = "";
            }
        }

        if (other.gameObject.tag == "Skill_122")
        {
            Parent.HP -= (uint)Parent.Reduce_Amount_Skill_122;

            Parent.Msg_UI.Open_ExpMon();
            Parent.Msg_UI.ExpMon_msg.text = Parent.HP.ToString();


            if (Parent.HP <= 1)
            {
                GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().target = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().TargetDefult;
                Destroy(this.gameObject);
                Parent.Msg_UI.Close_ExpMon();
                Parent.Msg_UI.ExpMon_msg.text = "";
            }
        }

        if (other.gameObject.tag == "Skill_123")
        {
            Parent.HP -= (uint)Parent.Reduce_Amount_Skill_123;

            Parent.Msg_UI.Open_ExpMon();
            Parent.Msg_UI.ExpMon_msg.text = Parent.HP.ToString();


            if (Parent.HP <= 1)
            {
                GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().target = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().TargetDefult;
                Destroy(this.gameObject);
                Parent.Msg_UI.Close_ExpMon();
                Parent.Msg_UI.ExpMon_msg.text = "";
            }
        }

    }
}
