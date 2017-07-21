using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mon_R_ON : MonoBehaviour {
    
    IG_MainAI AI;
    GameObject P;

    public static GameObject TARGET; //타겟
    public static GameObject Target_D; //디폴트타겟값
    public Collider MonAtk_L; // 어택콜라이더 켜고끄기
    public Collider MonAtk_R;

    public bool IsATK = false;    
    public bool IsLeaveAway = false;
   

    public Animator ani;


    private void Start()
    {
        AI = gameObject.transform.parent.GetComponent<IG_MainAI>();
        P = GameObject.FindGameObjectWithTag("Cha").gameObject;
        Target_D = AI.TargetDefult.gameObject;       
        TARGET = Target_D; 
    }
    private void Update()
    {                

        if (Vector3.Distance(TARGET.transform.position, transform.position) < 13f && TARGET.transform.gameObject != null)
        {
            ani.SetBool("IsRun", false);
            ani.SetBool("IsAtk", true);
            MonAtk_L.enabled = true;
            MonAtk_R.enabled = true;


        }
        else if (Vector3.Distance(TARGET.transform.position, transform.position) >= 13f && Vector3.Distance(TARGET.transform.position, transform.position) < 40f && TARGET.transform.gameObject != null)
        {
            ani.SetBool("IsGet", false);
            ani.SetBool("IsAtk", false);
            ani.SetBool("IsRun", true);
            MonAtk_L.enabled = false;
            MonAtk_R.enabled = false;
        }
        else if (Vector3.Distance(TARGET.transform.position, transform.position) >= 35f && TARGET.transform.gameObject != null)
        {
            ani.SetBool("IsGet", false);
            ani.SetBool("IsAtk", false);
            ani.SetBool("IsRun", true);
            GameInformation.Mon_R_ColOn();
            TARGET = Target_D;
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Cha_R")
        {
            TARGET = other.gameObject;

            GameInformation.Mon_R_ColOff();
        }

        else if (other.gameObject.tag == "ExpMon")
        {
            TARGET = other.gameObject;

            GameInformation.Mon_R_ColOff();
        }

        else if (other.gameObject.tag == "Marin" && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            TARGET = other.gameObject;

            GameInformation.Mon_R_ColOff();
        }

        else if (other.gameObject.tag == "Defence_ATK" && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            TARGET = other.gameObject;

            GameInformation.Mon_R_ColOff();
        }

        else if (other.gameObject.tag == "Nex" && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            TARGET = other.gameObject;
            //if (other.gameObject.tag == "Cha")
             //   TARGET = other.gameObject;
        }
        else
            TARGET = Target_D;

    }
}
