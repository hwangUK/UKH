using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cha_Body : MonoBehaviour {

    IG_MainPlayer P;

    private void Start() {
        P = transform.parent.GetComponent<IG_MainPlayer>();
    }

    void OnTriggerStay(Collider other) {
        //|( Skill_DF_100.Get_UPgrade == true && P.bSkill_DF_100 == true))

        if (other.gameObject.tag == "Resource" && transform.parent.GetComponent<UI_Button_Manager>().bGET_Base == true)
        {
            P.GetGetResource(other);

        }
        else if (other.gameObject.tag == "Resource" && transform.parent.GetComponent<UI_Button_Manager>().bGET_Base == false)
        {
            P.GetGetResource_End(other);
        }


        //if (other.gameObject.tag == "Exp_Mon_Player" && P.Isget == true)
        //{
        //    Player.NewPlayer.CurrentEXP += P.PlayerGet_InG_EXP;
        //
        //}

        if (other.gameObject.tag == "Forbid")
        {
            P.bCanBuild = false;
        }
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ExpMon_Atk")
        {
            Player.NewPlayer.CurrentHP -= P.DmgFromExpMon;
            StartCoroutine(BF_UICenter.Draw_DMG_Player(P.DmgFromExpMon));
        }
    }
}

    
