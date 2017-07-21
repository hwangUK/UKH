using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class HUD_Add_BF_ExpMon : MonoBehaviour {

    public BF_UI_RL_Information_Manager Msg_UI;
    public IG_MainAI AI;

    public int RewardEXP_min = 50;
    public int RewardEXP_Max = 200;
    public int ranEXP = 0;
    public uint HP = 10;

    public bool IsDie = false;
    
    public int Reduce_Amount_Atk = 1;

    public int Reduce_Amount_Skill_100 = 2;

    public int Reduce_Amount_Skill_110 = 3;

    public int Reduce_Amount_Skill_111 = 4;
    public int Reduce_Amount_Skill_112 = 4;
    public int Reduce_Amount_Skill_113 = 4;

    public int Reduce_Amount_Skill_120 = 3;

    public int Reduce_Amount_Skill_121 = 4;
    public int Reduce_Amount_Skill_122 = 4;
    public int Reduce_Amount_Skill_123 = 4;


    // Use this for initialization
    //public Text t;
    
    public Animator anim;

    private void Awake()
    {
        Msg_UI = GameObject.FindGameObjectWithTag("Infor_BF").GetComponent<BF_UI_RL_Information_Manager>();
        AI = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {        
        ranEXP = Random.Range(RewardEXP_min, RewardEXP_Max);
        StartCoroutine(Check_die());
        anim.SetBool("IsAtk", false);
        anim.SetBool("IsRun", false);
        anim.SetBool("IsDmg", false);
    }
    IEnumerator Check_die()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.8f);
            if(IsDie == true)
            {
                StartCoroutine(die());
                GetComponent<NavMeshAgent>().speed = 0f;
                GetComponent<NavMeshAgent>().angularSpeed = 0f;
                GetComponent<NavMeshAgent>().enabled = false;
                GetComponent<Collider>().enabled = false;
                transform.GetChild(3).GetComponent<Collider>().enabled = false; //탐지콜라이더끔

                anim.SetBool("IsAtk", false);
                anim.SetBool("IsRun", false);
                anim.SetBool("IsDmg", false);
                anim.SetTrigger("IsDie");
                break;
            }
        }
    }
    
    public IEnumerator coolTimeOff_ExpMon()
    {
        yield return new WaitForSeconds(1.5f);
        Msg_UI.Close_ExpMon();
        Msg_UI.ExpMon_msg.text = "";
    }

    public IEnumerator coolTimeOff_Gold()
    {
        yield return new WaitForSeconds(1.5f);
        Msg_UI.Close_GoldMon();
        Msg_UI.GoldMon_msg.text = "";
    }

    public IEnumerator die()
    {
        GameInformation.Mon_R_ColOn();
        yield return new WaitForSeconds(4.2f);
        Destroy(this.gameObject);
    }

}
