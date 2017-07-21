using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class IG_MainAI : MonoBehaviour {

    public Information_Base_Player EnemyObj;

    Transform HUD_AI_ParentFind;
    Transform HUD_Player_ParentFind;


    NavMeshAgent nav;
    //public Transform target;
    GameObject P;

    int BulidCount = 0;
    public int BaseHP = 500;
    public Transform target;
    public Transform TargetDefult;
    private Animator ani;
    public string TargetDefult_Atk_Cha = "Cha";
    public string TargetDefult_Atk_Nex = "Nex";
    public bool IsATK = false;
    //--------------HP

    public Camera UI_Camera;
    public GameObject HUD;
    public GameObject HUDCamPos;

    public GameObject HudDmg_Text;

    public bool IsDamaged = false;
    public bool IsLeaveAway = false;


    public int Player_ReduceHP;
    public int TakeDmg_ExpMon_ReduceHP;
    public int TakeDmg_Marin_ReduceHP;
    public int TakeDmg_112Bullet_ReduceHP;

    public int TakeDmg_DfenATKDmg = 2;

    private Text[] HUDs;

    public int SkillDMG_100;
    public int SkillDMG_110;
    public int SkillDMG_111;
    public int SkillDMG_112;
    public int SkillDMG_113;

    public int SkillDMG_120;
    public int SkillDMG_121;
    public int SkillDMG_122;
    public int SkillDMG_123;
    // Use this for initialization
    
    void Start() {
        P = GameObject.FindGameObjectWithTag("Cha").gameObject;
        EnemyObj = new Information_Base_Player();
        EnemyObj.playerIngameLevel = 2;

        HUDs = transform.GetChild(3).GetComponentsInChildren<Text>();

        HUD_AI_ParentFind = transform.GetChild(3).transform;
        HUD_Player_ParentFind = GameObject.FindGameObjectWithTag("Cha").transform.GetChild(5).transform;

        SetDrawHUD();

        nav = GetComponent<NavMeshAgent>();
        ani = GetComponent<Animator>();


        if (Player.NewPlayer.IsATKDEF_12 == 1)
        {
            TargetDefult = GameObject.FindGameObjectWithTag(TargetDefult_Atk_Cha).transform;
        }
        else
        {
            TargetDefult = GameObject.FindGameObjectWithTag(TargetDefult_Atk_Nex).transform;
        }        
        target = TargetDefult;
    }

    // Update is called once per frame
    void Update() {
        Draw_Level();
        Draw_HP();
        Draw_EXP();

        Rendering_Bar();
    }

    void LateUpdate() {
        ScreenToWorld();
        MoveFunc();
    }

    //START *****************************
    void SetDrawHUD()
    {
        EnemyObj.MaxHP = BaseHP +(EnemyObj.playerIngameLevel * 100);
        EnemyObj.CurrentHP = EnemyObj.MaxHP;
        EnemyObj.RequirEXP = EnemyObj.playerIngameLevel * 200;
    }

    //UPDATE *****************************
    void Rendering_Bar()
    {
        float F_HP = (float)EnemyObj.CurrentHP;
        float F_LV = (float)EnemyObj.playerIngameLevel + (float)(BaseHP /100);
        float GetHP = (F_HP / F_LV) * 0.01f;

        HUD.transform.FindChild("Health_BackBar").FindChild("Health_Bar").transform.localScale = new Vector3(GetHP, 1f, 1f);
    }

    void Draw_Level()
    {
        if (Player.NewPlayer.IsATKDEF_12 == 2)
        {
            HUDs[0].text = EnemyObj.playerIngameLevel.ToString();
        }
        else
            HUDs[0].text = "";

    }

    void Draw_HP()
    {
        //Debug.Log (hpvalue+"/"+MAXhp+"E");
        HUDs[1].text = EnemyObj.CurrentHP.ToString() + "/" + EnemyObj.MaxHP.ToString();
        if (EnemyObj.CurrentHP <= 0)
        {
            GameObject.Find("0.BattleFieldManager").GetComponent<InforBF_Manager>().Win();
            Player.MODEL.transform.localPosition = new Vector3(0f, 0f, 0f);
            this.transform.localPosition = new Vector3(500f, 500f, 500f);
            return;
        }
    }

    void Draw_EXP()
    {
        //Debug.Log (ExpValue.ToString() + ": EXP E");
        if(Player.NewPlayer.IsATKDEF_12 == 2)
        {
            HUDs[2].text = EnemyObj.CurrentEXP.ToString() + "/" + EnemyObj.RequirEXP.ToString();
            if (EnemyObj.CurrentEXP >= EnemyObj.RequirEXP)
            {
                EnemyObj.playerIngameLevel += 1;
                EnemyObj.CurrentEXP = 0;
                SetDrawHUD();
            }
        }
        else
        {
            HUDs[2].text = "자원"+ EnemyObj.CurrentEXP.ToString();
            if(EnemyObj.CurrentEXP >= 150 && BulidCount == 0)
            {
                BulidCount += 1;
                //1번스킬
            }
            else if (EnemyObj.CurrentEXP >= 500 && BulidCount >= 1)
                {
                    BulidCount += 1;
                    //2번스킬
                }
        }
        
    }

    //CAMERA*****************************
    void ScreenToWorld()
    {
        Vector3 HUD_POS;
        HUD_POS = HUDCamPos.transform.position;
        Vector3 screenPos = Camera.main.WorldToScreenPoint(HUD_POS);
        Vector3 viewPos = Camera.main.ScreenToViewportPoint(screenPos);
        Vector3 worldpos = UI_Camera.ViewportToWorldPoint(viewPos);

        HUD.transform.position = worldpos;
    }


    //AI_MOVE****************************
    void MoveFunc()
    {
        if (Mon_R_ON.TARGET == null)
            return;
        nav.destination = Mon_R_ON.TARGET.transform.position;
        
    }

    //CRASH CHECK************************

    public IEnumerator Draw_DMG_AI(int InputDMG)
    {

        GameObject ta = Instantiate(HudDmg_Text, HUD_AI_ParentFind.transform);
        ta.GetComponent<Text>().text = InputDMG.ToString();
        ta.GetComponent<Text>().color = Color.yellow;
        ta.GetComponent<Text>().resizeTextForBestFit = true;
        yield return new WaitForSeconds(0.8f);
        Destroy(ta.gameObject);

    }

    public IEnumerator Draw_DMG_Player(int InputDMG)
    {

        GameObject tp = Instantiate(HudDmg_Text, HUD_Player_ParentFind.transform);
        tp.GetComponent<Text>().text = InputDMG.ToString();
        tp.GetComponent<Text>().color = Color.red;
        tp.GetComponent<Text>().resizeTextForBestFit = true;
        yield return new WaitForSeconds(0.8f);
        Destroy(tp.gameObject);

    }


    void OnTriggerEnter(Collider other)
    {

        // Take Damage===========
        if (other.gameObject.tag == "ExpMon_Atk")
        {
            EnemyObj.CurrentHP -= TakeDmg_ExpMon_ReduceHP;
            StartCoroutine(Draw_DMG_AI(TakeDmg_ExpMon_ReduceHP));
        }

        if (other.gameObject.tag == "Cha_Atk")
        {
            EnemyObj.CurrentHP -= Player_ReduceHP;
            StartCoroutine(Draw_DMG_AI(Player_ReduceHP));
        }

        if (other.gameObject.tag == "Marin_Atk")
        {
            EnemyObj.CurrentHP -= TakeDmg_Marin_ReduceHP;
            StartCoroutine(Draw_DMG_AI(TakeDmg_Marin_ReduceHP));
        }

        if (other.gameObject.tag == "Skill_100")
        {
            EnemyObj.CurrentHP -= SkillDMG_100;
            StartCoroutine(Draw_DMG_AI(SkillDMG_100));
        }

        if (other.gameObject.tag == "Skill_110")
        {
            EnemyObj.CurrentHP -= SkillDMG_110;
            StartCoroutine(Draw_DMG_AI(SkillDMG_110));
        }
        if (other.gameObject.tag == "Skill_111")
        {
            EnemyObj.CurrentHP -= SkillDMG_111;
            StartCoroutine(Draw_DMG_AI(SkillDMG_111));
        }
        if (other.gameObject.tag == "Skill_112")
        {
            EnemyObj.CurrentHP -= SkillDMG_112;
            StartCoroutine(Draw_DMG_AI(SkillDMG_112));
        }
        if (other.gameObject.tag == "Skill_113")
        {
            EnemyObj.CurrentHP -= SkillDMG_113;
            StartCoroutine(Draw_DMG_AI(SkillDMG_113));
        }

        if (other.gameObject.tag == "Skill_120")
        {
            EnemyObj.CurrentHP -= SkillDMG_120;
            StartCoroutine(Draw_DMG_AI(SkillDMG_120));
        }
        if (other.gameObject.tag == "Skill_121")
        {
            EnemyObj.CurrentHP -= SkillDMG_121;
            StartCoroutine(Draw_DMG_AI(SkillDMG_121));
        }
        if (other.gameObject.tag == "Skill_122")
        {
            EnemyObj.CurrentHP -= SkillDMG_122;
            StartCoroutine(Draw_DMG_AI(SkillDMG_122));
        }
        if (other.gameObject.tag == "Skill_123,")
        {
            EnemyObj.CurrentHP -= SkillDMG_123;
            StartCoroutine(Draw_DMG_AI(SkillDMG_123));
        }

        if (other.gameObject.tag == "Marin")
        {
            EnemyObj.CurrentHP -= TakeDmg_Marin_ReduceHP;
            StartCoroutine(Draw_DMG_AI(TakeDmg_Marin_ReduceHP));
        }

        if (other.gameObject.tag == "Df_112_Bullet")
        {
            EnemyObj.CurrentHP -= TakeDmg_112Bullet_ReduceHP;
            StartCoroutine(Draw_DMG_AI(TakeDmg_112Bullet_ReduceHP));
        }
    }    
}
 
/*if (IsEnemyTrue)
   {
       HUDs[3].text = InputDMG.ToString();
       HUDs[3].color = Color.red;
       PlayerLoad.HUDs[3].resizeTextForBestFit = true;

       HUDs[3].rectTransform.localPosition = new Vector3(20f, -15f, 1f);
       yield return new WaitForSeconds(0.1f);
       HUDs[3].rectTransform.localPosition = new Vector3(20f, -12f, 1f);
       yield return new WaitForSeconds(0.2f);
       HUDs[3].rectTransform.localPosition = new Vector3(20f, -9f, 1f);
       yield return new WaitForSeconds(0.3f);
       HUDs[3].rectTransform.localPosition = new Vector3(20f, -6f, 1f);
       yield return new WaitForSeconds(0.4f);
       HUDs[3].rectTransform.localPosition = new Vector3(20f, -3f, 1f);
       yield return new WaitForSeconds(0.5f);

       Debug.Log("DMG_AI");     

       HUDs[3].text = null;

       yield return null;
   }
   else
   {
       PlayerLoad.HUDs[3].text = InputDMG.ToString();
       PlayerLoad.HUDs[3].color = Color.red;
       PlayerLoad.HUDs[3].resizeTextForBestFit = true;


       PlayerLoad.HUDs[3].rectTransform.localPosition = new Vector3(40f, -10f, 1f);
       yield return new WaitForSeconds(0.1f);
       PlayerLoad.HUDs[3].rectTransform.localPosition = new Vector3(40f, -8f, 1f);
       yield return new WaitForSeconds(0.2f);
       PlayerLoad.HUDs[3].rectTransform.localPosition = new Vector3(40f, -6f, 1f);
       yield return new WaitForSeconds(0.3f);
       PlayerLoad.HUDs[3].rectTransform.localPosition = new Vector3(40f, -4f, 1f);
       yield return new WaitForSeconds(0.4f);
       PlayerLoad.HUDs[3].rectTransform.localPosition = new Vector3(40f, -2f, 1f);
       yield return new WaitForSeconds(0.5f);
       PlayerLoad.HUDs[3].rectTransform.localPosition = new Vector3(40f, 0f, 1f);

       Debug.Log("DMG_PLAYER");

       PlayerLoad.HUDs[3].text = null;
       yield return null;
   }


   //HUDs[3].transform.localScale = new Vector3(HUDs[3].transform.localScale.x * Time.deltaTime, HUDs[3].transform.localScale.y * Time.deltaTime, HUDs[3].transform.localScale.z * Time.deltaTime);
   */

/*public IEnumerator Draw_DMG(int InputDMG)
{
    HUDs[3].text = InputDMG.ToString();
    GameObject HUDdmg = Instantiate(HUD_DMG);
    HUDdmg.GetComponentInChildren<Text>().text = InputDMG.ToString();
    //HUDs[3].transform.localScale = new Vector3(HUDs[3].transform.localScale.x * Time.deltaTime, HUDs[3].transform.localScale.y * Time.deltaTime, HUDs[3].transform.localScale.z * Time.deltaTime);
    Debug.Log("DMGHUD");
    yield return new WaitForSeconds(1.7f);
    HUDs[3].text = null;
    yield return null;
}*/
//REDUCE HEALTH --------->

/*IEnumerator Reduce_State_coroutine(){
    if (IsDamaged) {
        ReduceHealth ();
        yield return null;
        Rendering_Bar ();
    } else {
        yield return new WaitForSeconds(0.5f);
        Reduce_State_coroutine ();
    }
    //ReduceMana ();


}

 void ReduceHealth()
{
    if (EnemyObj.CurrentHP >= 1) {
        EnemyObj.CurrentHP -= EnemyDamaged;
    } else {
        EnemyDamaged = 0;
    }
}*/

/*
public void GoStop()
{

    TargetFind();
    Debug.Log(target.tag);
    nav.destination = target.position;

    if (Vector3.Distance(target.position, transform.position) < 13f && target.gameObject != null)
    {
        IsATK = true;
    }
    else if (Vector3.Distance(target.position, transform.position) >= 13f && Vector3.Distance(target.position, transform.position) < 40f && target.gameObject != null)
    {
        IsATK = false;
    }
    else if (Vector3.Distance(target.position, transform.position) >= 35f && target.gameObject != null)
    {
        IsLeaveAway = true;
        //GameInformation.Mon_R_ColOn();
    }
}


public void TargetFind()
{


    if (target.gameObject == null)
        return;

    if (IsATK == true)
    {
        ani.SetBool("IsRun", false);
        ani.SetBool("IsAtk", true);
    }

    else if (IsATK == false)
    {
        ani.SetBool("IsGet", false);
        ani.SetBool("IsAtk", false);
        ani.SetBool("IsRun", true);
    }

    if (IsLeaveAway == true)
    {
        Mon_R_ON.IsCHA = false;
        Mon_R_ON.IsDef_Atk = false;
        Mon_R_ON.IsExpMon = false;
        Mon_R_ON.IsMarin = false;
        Mon_R_ON.IsNex = false;

        //GameInformation.Mon_R_ColOn();
        target = TargetDefult;
        IsLeaveAway = false;
    }

    /*if(Mon_R_ON.IsCHA == true && Mon_R_ON.IsExpMon == false && Mon_R_ON.IsDef_Atk == false && Mon_R_ON.IsMarin == false && Mon_R_ON.IsNex == false)
    {
        target = P.transform;
    }
    //cha

    else if (Mon_R_ON.IsCHA == false && Mon_R_ON.IsExpMon == true && Mon_R_ON.IsDef_Atk == false && Mon_R_ON.IsMarin == false && Mon_R_ON.IsNex == false)
    {
        target = GameObject.FindGameObjectWithTag("Mon_R_ON").GetComponent<Mon_R_ON>().SaveExpMonTarget.transform;
    }
    //expmon

    else if (Mon_R_ON.IsCHA == false && Mon_R_ON.IsExpMon == false && Mon_R_ON.IsDef_Atk == true && Mon_R_ON.IsMarin == false && Mon_R_ON.IsNex == false)
    {
        target = GameObject.FindGameObjectWithTag("Mon_R_ON").GetComponent<Mon_R_ON>().SaveDFBuildingTarget.transform;
    }
    //DefAtk

    else if (Mon_R_ON.IsCHA == false && Mon_R_ON.IsExpMon == false && Mon_R_ON.IsDef_Atk == false && Mon_R_ON.IsMarin == true && Mon_R_ON.IsNex == false)
    {
        target = GameObject.FindGameObjectWithTag("Marin").gameObject.transform;
    }
    //Marin

   // else if (Mon_R_ON.IsCHA == false && Mon_R_ON.IsExpMon == false && Mon_R_ON.IsDef_Atk == false && Mon_R_ON.IsMarin == false && Mon_R_ON.IsNex == true)
   // {
   //     target = TargetDefult;
   // }
    //nex

    else if(Mon_R_ON.IsCHA == false && Mon_R_ON.IsExpMon == false && Mon_R_ON.IsMarin == false && Mon_R_ON.IsDef_Atk == false && Mon_R_ON.IsNex == false)
    {
        target = TargetDefult;
        IsATK = false;
    }
    nav.destination = target.position;*/

