using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IG_MainPlayer : MonoBehaviour {

    public bool bCanBuild = true;
    public Text[] HUDs;

    public int BaseHP = 500;

    public bool bButtonU = false;
	public bool bButtonUR = false;
	public bool bButtonUL = false;
	public bool bButtonL = false;
	public bool bButtonR = false;
	public bool bButtonD = false;
	public bool bButtonDL = false;
	public bool bButtonDR = false;
	public bool Isget = false;
	public bool IsAtk = false;
	public bool Isbuild = false;

    public bool bSkill_DF_100 = false;

	public float walkSpeed = 5f;
	public float runSpeed = 15f;
    public bool bButton_Skill_01;

    public Animator ani;

	public GameObject Build_Barak;
	public Camera UI_Camera;
	public GameObject HUD;
	public GameObject HUDCamPos;
    BF_UI_RL_Information_Manager MsgView_RL;

    //private float player_NOW_Health = 1f;
	private bool IsATK_ReduceHP = false;
	//public float Player_Damage_Amount;

    
    public int PlayerGet_InG_EXP = 3;
    public int PlayerGet_InG_Resource_EXP = 1;
    public int Player_ReduceHP = 1;

    public int DmgFromExpMon = 1;


    //------------skill

    public static int LVUP_Point = 0;
    GameObject SkillBtn_Load;    

    //------------skill_attak

    public GameObject skill_100_Attack;

    public GameObject skill_110_Attack;
    public GameObject skill_111_Attack;
    public GameObject skill_112_Attack;
    public GameObject skill_113_Attack;

    public GameObject skill_120_Attack;
    public GameObject skill_121_Attack;
    public GameObject skill_122_Attack;
    public GameObject skill_123_Attack;

    public float A_100_SkillLiveTime = 3.5f;
    public float A_110_SkillLiveTime = 3.5f;
    public float A_111_SkillLiveTime = 3.5f;
    public float A_112_SkillLiveTime = 3.5f;
    public float A_113_SkillLiveTime = 3.5f;

    public float A_120_SkillLiveTime = 3.5f;
    public float A_121_SkillLiveTime = 3.5f;
    public float A_122_SkillLiveTime = 3.5f;
    public float A_123_SkillLiveTime = 3.5f;

    public float S_100_CoolTime = 2f;
    public float S_110_CoolTime = 8f;
    public float S_111_CoolTime = 2f;
    public float S_112_CoolTime = 3f;
    public float S_113_CoolTime = 2f ;
    public float S_120_CoolTime = 4f;
    public float S_121_CoolTime = 10f;
    public float S_122_CoolTime = 5f;
    public float S_123_CoolTime = 12f;

    public bool bDF_100_SCool_Ing;
    public bool bDF_110_SCool_Ing;

    //------------skill_Defence

    public GameObject skill_100_Defence;

    public GameObject skill_110_Defence;
    public GameObject skill_111_Defence;
    public GameObject skill_112_Defence;
    public GameObject skill_113_Defence;

    public GameObject skill_120_Defence;
    public GameObject skill_121_Defence;
    public GameObject skill_122_Defence;
    public GameObject skill_123_Defence;



    public float S_100_Defence_CoolTime = 12f;
    public float S_110_Defence_CoolTime = 8f;
    public float S_111_Defence_CoolTime = 2f;
    public float S_112_Defence_CoolTime = 3f;
    public float S_113_Defence_CoolTime = 2f;
    public float S_120_Defence_CoolTime = 4f;
    public float S_121_Defence_CoolTime = 10f;
    public float S_122_Defence_CoolTime = 5f;
    public float S_123_Defence_CoolTime = 12f;

    public int S_100_Defence_Gold = 300;
    public int S_110_Defence_Gold = 700;
    public int S_111_Defence_Gold = 1501;
    public int S_112_Defence_Gold = 1502;
    public int S_113_Defence_Gold = 1503;
    public int S_120_Defence_Gold = 850;
    public int S_121_Defence_Gold = 1501;
    public int S_122_Defence_Gold = 1502;
    public int S_123_Defence_Gold = 1503;

    void Start () {
        SkillBtn_Load = transform.GetChild(6).GetChild(11).gameObject;
        MsgView_RL = GameObject.FindGameObjectWithTag("Infor_BF").GetComponent<BF_UI_RL_Information_Manager>();
        HUDs = transform.GetChild(5).GetComponentsInChildren<Text>();
        Player.NewPlayer.playerIngameLevel = 1;
        SetDrawHUD();
        bDF_100_SCool_Ing = false;
        //StartCoroutine(Check_HUD_AorD_ToUpdate());
        //StartCoroutine(Reduce_State_coroutine());

    }
    private void Update()
    {
        MoveAndAni();
        //UpdateHUDstate();
        Rendering_Bar();
        bCanBuild = true;
    }
    	


	void LateUpdate () {
        
		ScreenToWorld ();
        Check_HUD_AorD_ToUpdate();
    }
    
    //+++++++++++++++++++++++++++++++++++++++++++++++
	//REDUCE HEALTH --------->

	IEnumerator Reduce_State_coroutine(){
		if (IsATK_ReduceHP) {
			//ReduceHealth ();
			yield return null;
			Rendering_Bar ();
		} else {
			yield return new WaitForSeconds(0.5f);
			Reduce_State_coroutine ();
		}
		//ReduceMana ()
	}

	//private void ReduceHealth()
	//{
	//	if (player_NOW_Health >= 0.0001f) {
	//		Player_Damage_Amount *= 0.01f;
	//		player_NOW_Health -= Player_Damage_Amount;
	//		Player_Damage_Amount *= 100f;
	//	} else {
	//		player_NOW_Health = 0f;
	//	}
	//}
    //+++++++++++++++++++++++++++++++++++++++++++++++

	private void Rendering_Bar(){
        float F_HP = (float)Player.NewPlayer.CurrentHP;
        float F_LV = (float)Player.NewPlayer.playerIngameLevel +(float)(BaseHP /100);
        float GetHP = (F_HP / F_LV) * 0.01f;
        //float GetHP = F_HP * 0.01f;
        HUD.transform.FindChild ("Health_BackBar").FindChild ("Health_Bar").transform.localScale = new Vector3 (GetHP, 1f, 1f);

	}



	//CAMERA------->
	private void ScreenToWorld(){

		Vector3 HUD_POS;
		HUD_POS = HUDCamPos.transform.position;
		Vector3 screenPos = Camera.main.WorldToScreenPoint (HUD_POS);
		Vector3 viewPos = Camera.main.ScreenToViewportPoint (screenPos);
		Vector3 worldpos = UI_Camera.ViewportToWorldPoint (viewPos);

		HUD.transform.position = worldpos;
	}

	//_______CAMERA



	public void Build(){
		Isbuild = true;
		if (Isbuild) {
			Build_Barak = Instantiate (Build_Barak, new Vector3(transform.position.x, transform.position.y, transform.position.z+5f), Quaternion.identity);
		}

	}


	//CHARACTERMOVE--------->

	public void MoveAndAni(){
		if (bButtonU | bButtonUR | bButtonUL | bButtonL | bButtonR | bButtonD | bButtonDL | bButtonDR) {
			//walkToRun_time = walkToRun_time + Time.deltaTime;
			transform.Translate (Vector3.forward * runSpeed * Time.deltaTime);
			ani.SetBool ("param_idletorunning", true);
            ani.SetBool("param_idletowinpose", false);

            /*if (walkToRun_time >= 1.5f) {
				transform.Translate (Vector3.forward * runSpeed * Time.deltaTime);
				ani.SetBool ("param_idletowalk",false);
				ani.SetBool ("param_idletorunning",true);
			}*/

        } 
		else {
			transform.Translate (Vector3.zero);

			//walkToRun_time = 0f;
			ani.SetBool ("param_idletowalk",false);
			ani.SetBool ("param_idletorunning", false);
		}


		//if (Isget) {
		//	ani.SetBool ("param_idletowinpose", true);
		//	transform.Translate (Vector3.zero);
		//}else {
		//	ani.SetBool ("param_idletowinpose", false);
		//}

		if (IsAtk) {
			ani.SetBool ("param_idletohit01", true);
			transform.Translate (Vector3.zero);
		} else {
			ani.SetBool ("param_idletohit01", false);
		}
		if (bButtonU) {
			transform.rotation = Quaternion.Euler (0f,0f,0f);
		}
		if (bButtonD) {
			transform.rotation = Quaternion.Euler (0f,180f,0f);
		}
		if (bButtonL) {
			transform.rotation = Quaternion.Euler (0f,270f,0f);
		}
		if (bButtonR) {
			transform.rotation = Quaternion.Euler (0f,90f,0f);
		}

		if (bButtonUL) {
			transform.rotation = Quaternion.Euler (0f,315f,0f);
		}
		if (bButtonUR) {
			transform.rotation = Quaternion.Euler (0f,45f,0f);
		}
		if (bButtonDL) {
			transform.rotation = Quaternion.Euler (0f,225f,0f);
		}
		if (bButtonDR) {
			transform.rotation = Quaternion.Euler (0f,135f,0f);
		}
        
	}
    //________CHARACTERMOVE
    //--------SKILL_Attake
    
    public void SkillInstantiate_Attack_100()
    {       
        StartCoroutine(SkillInstant_Attack_100());
        StartCoroutine(Skill_100_Attack_CoolTime());        
    }    
    public void SkillInstantiate_Attack_110()
    {
        StartCoroutine(SkillInstant_Attack_110());
        StartCoroutine(Skill_110_Attack_CoolTime());
    }
    public void SkillInstantiate_Attack_111()
    {
        StartCoroutine(SkillInstant_Attack_111());
        StartCoroutine(Skill_111_Attack_CoolTime());
    }
    public void SkillInstantiate_Attack_112()
    {
        StartCoroutine(SkillInstant_Attack_112());
        StartCoroutine(Skill_112_Attack_CoolTime());
    }
    public void SkillInstantiate_Attack_113()
    {
        StartCoroutine(SkillInstant_Attack_113());
        StartCoroutine(Skill_113_Attack_CoolTime());
    }

    public void SkillInstantiate_Attack_120()
    {
        StartCoroutine(SkillInstant_Attack_120());
        StartCoroutine(Skill_120_Attack_CoolTime());
    }
    public void SkillInstantiate_Attack_121()
    {
        StartCoroutine(SkillInstant_Attack_121());
        StartCoroutine(Skill_121_Attack_CoolTime());
    }
    public void SkillInstantiate_Attack_122()
    {
        StartCoroutine(SkillInstant_Attack_122());
        StartCoroutine(Skill_122_Attack_CoolTime());
    }
    public void SkillInstantiate_Attack_123()
    {
        StartCoroutine(SkillInstant_Attack_123());
        StartCoroutine(Skill_123_Attack_CoolTime());
    }
    //-----def-----------------------------------------------
    
    public void SkillInstantiate_Defence_100()
    {        
        StartCoroutine(SkillInstant_Defence_100());
        StartCoroutine(Skill_100_Defence_CoolTime());
    }

    /*public void SkillInstantiate_Defence_100_T()
    {
        if (bCanBuild)
        {
            //StartCoroutine(SkillInstant_Defence_100());
            //StartCoroutine(Skill_100_Defence_CoolTime());
        }
            //StartCoroutine(Msg_CanNotBuild());
    }*/

    public void SkillInstantiate_Defence_110()
    {
        if (bCanBuild)
        {
            StartCoroutine(SkillInstant_Defence_110());
            StartCoroutine(Skill_110_Defence_CoolTime());
        }
        else
            StartCoroutine(Msg_CanNotBuild());
    }

    public void SkillInstantiate_Defence_111()
    {
        if (bCanBuild)
        {
            StartCoroutine(SkillInstant_Defence_111());
            StartCoroutine(Skill_111_Defence_CoolTime());
        }
        else
            StartCoroutine(Msg_CanNotBuild());
    }
    public void SkillInstantiate_Defence_112()
    {
        if (bCanBuild)
        {
            StartCoroutine(SkillInstant_Defence_112());
            StartCoroutine(Skill_112_Defence_CoolTime());
        }
        else
            StartCoroutine(Msg_CanNotBuild());
    }
    public void SkillInstantiate_Defence_113()
    {
        if (bCanBuild)
        {
            StartCoroutine(SkillInstant_Defence_113());
            StartCoroutine(Skill_113_Defence_CoolTime());
        }
        else
            StartCoroutine(Msg_CanNotBuild());
    }

    public void SkillInstantiate_Defence_120()
    {
        if (bCanBuild)
        {
            StartCoroutine(SkillInstant_Defence_120());
            StartCoroutine(Skill_120_Defence_CoolTime());
        }
        else
            StartCoroutine(Msg_CanNotBuild());
    }
    public void SkillInstantiate_Defence_121()
    {
        if (bCanBuild)
        {
            StartCoroutine(SkillInstant_Defence_121());
            StartCoroutine(Skill_121_Defence_CoolTime());
        }
        else
            StartCoroutine(Msg_CanNotBuild());
    }
    public void SkillInstantiate_Defence_122()
    {
        if (bCanBuild)
        {
            StartCoroutine(SkillInstant_Defence_122());
            StartCoroutine(Skill_122_Defence_CoolTime());
        }
        else
            StartCoroutine(Msg_CanNotBuild());
    }
    public void SkillInstantiate_Defence_123()
    {
        if (bCanBuild)
        {
            StartCoroutine(SkillInstant_Defence_123());
            StartCoroutine(Skill_123_Defence_CoolTime());
        }
        else
            StartCoroutine(Msg_CanNotBuild());

    }

    //###################################################################################
    IEnumerator Msg_CanNotBuild()
    {
        BF_UICenter.Draw_Msg_MoveUp("지대가 불안정해서 건물을 지을수 없습니다");
        yield return null;
    }

    IEnumerator SkillInstant_Attack_100()
    {
        
        GameObject obj = Instantiate(skill_100_Attack, transform.position + new Vector3(0f, 1.5f, 5f), Quaternion.identity);
        BF_UICenter.Draw_Msg_Balloon("불꽃이여..");
        //obj.transform.localPosition = new Vector3(0f,1f,1f);        
        obj.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f);
        yield return new WaitForSeconds(A_100_SkillLiveTime);
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Attack_110()
    {

        GameObject obj = Instantiate(skill_110_Attack, transform.position + new Vector3(0f, 0f, 5f), Quaternion.identity);
        BF_UICenter.Draw_Msg_Balloon("날벼락");
        obj.transform.localScale = new Vector3(1f, 1f, 1f);
        //obj.transform.localScale = new Vector3(1f*Time.deltaTime * 0.3f, 1f * Time.deltaTime * 0.3f, 1f * Time.deltaTime * 0.3f);
        obj.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
        yield return new WaitForSeconds(A_110_SkillLiveTime);
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Attack_111()
    {

        GameObject obj = Instantiate(skill_111_Attack, transform.position + new Vector3(0f, 0f, 5f), Quaternion.identity);
        BF_UICenter.Draw_Msg_Balloon("이건어때?");
        obj.transform.localScale = new Vector3(1f, 1f, 1f);
        obj.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
        yield return new WaitForSeconds(A_111_SkillLiveTime);
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Attack_112()
    {

        GameObject obj = Instantiate(skill_112_Attack, transform.position + new Vector3(0f, 1.5f, 5f), Quaternion.identity);
        BF_UICenter.Draw_Msg_Balloon("아름답지?");
        //obj.transform.localPosition = new Vector3(1f, 1f, 1f);
        obj.transform.localScale = new Vector3(1f, 1.7f, 1f);
        obj.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
        yield return new WaitForSeconds(A_112_SkillLiveTime);
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Attack_113()
    {

        GameObject obj = Instantiate(skill_113_Attack, transform.position + new Vector3(0f, 1.5f, 5f), Quaternion.identity);
        BF_UICenter.Draw_Msg_Balloon("이건 몰랐을꺼야");
        //obj.transform.localPosition = new Vector3(1f, 1f, 1f);
        obj.transform.localScale = new Vector3(1f, 1f, 1f);
        obj.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
        yield return new WaitForSeconds(A_113_SkillLiveTime);
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Attack_120()
    {

        GameObject obj = Instantiate(skill_120_Attack, transform.position + new Vector3(0f, 12f, 5f), Quaternion.identity);
        BF_UICenter.Draw_Msg_Balloon("더 뜨겁게");
        //obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 4f, obj.transform.localPosition.z +2f);
        obj.transform.localScale = new Vector3(1f, 1f, 1f);
        obj.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);

        yield return new WaitForSeconds(A_120_SkillLiveTime);
       
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Attack_121()
    {
        //강화 TEXT!
        GameObject obj = Instantiate(skill_121_Attack, transform.position + new Vector3(0f, 1.5f, 5f), Quaternion.identity);
        BF_UICenter.Draw_Msg_Balloon("이건 몰랐을꺼야");
        obj.transform.localScale = new Vector3(1f, 1f, 1f);
        obj.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);

        yield return new WaitForSeconds(A_121_SkillLiveTime);

        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Attack_122()
    {

        GameObject obj = Instantiate(skill_122_Attack, transform.position + new Vector3(0f, 1.5f, 5f), Quaternion.identity);
        BF_UICenter.Draw_Msg_Balloon("가슴속 까지 차갑게");
        obj.transform.localScale = new Vector3(1f, 1f, 1f);
        obj.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
        yield return new WaitForSeconds(A_122_SkillLiveTime);
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Attack_123()
    {

        GameObject obj = Instantiate(skill_123_Attack, transform.position + new Vector3(0f, 2f, 5f), Quaternion.identity);
        BF_UICenter.Draw_Msg_Balloon("어둠이여..");
        obj.transform.localScale = new Vector3(1f, 1f, 1f);
        obj.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
        yield return new WaitForSeconds(A_123_SkillLiveTime);
        Destroy(obj.gameObject);
        yield return null;

    }

    //====def

    IEnumerator SkillInstant_Defence_100()
    {
        //활성화 
        //겟 버튼에서 인스턴스생성   
        BF_UICenter.Draw_Msg_Balloon("모두 캐주겠어!!");
        bSkill_DF_100 = true;
        Player.NewPlayer.Resources -= S_100_Defence_Gold; // 자원 소비    

        GameObject obj100 = Instantiate(skill_100_Defence, transform);
        yield return new WaitForSeconds(S_100_Defence_CoolTime);
        ani.SetBool("param_idletowinpose", false);
        bSkill_DF_100 = false;
        BF_UICenter.Draw_Msg_NoMove_OFF();
        Destroy(obj100.gameObject);
        
    }

    IEnumerator SkillInstant_Defence_110()
    {
        BF_UICenter.Draw_Msg_Balloon("나와라 나의 꼬붕이여!!");
        GameObject obj = Instantiate(skill_110_Defence,transform.position + new Vector3(0f, 0f, 5f), Quaternion.identity);
        
        Player.NewPlayer.Resources -= S_110_Defence_Gold;// 자원 소비
        
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        
        yield return new WaitForSeconds(51.6f - 1.4f);
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Defence_111()
    {
        BF_UICenter.Draw_Msg_Balloon("이 슬라임은 말을 잘 듣는것 같군!!");
        GameObject obj = Instantiate(skill_111_Defence, transform.position + new Vector3(0f, 0f, 5f), Quaternion.identity);
        Player.NewPlayer.Resources -= S_111_Defence_Gold;// 자원 소비
        
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.1f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        yield return new WaitForSeconds(0.05f);
        obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y + 0.05f, obj.transform.localPosition.z);
        
        yield return new WaitForSeconds(51.6f - 1.4f);
        GameObject.FindGameObjectWithTag("Mon_R_ON").GetComponent<Collider>().enabled = true;
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Defence_112()
    {
        BF_UICenter.Draw_Msg_Balloon("절대방어 수호탑!!");
        GameObject obj = Instantiate(skill_112_Defence, transform.position + new Vector3(0f, 0f, 5f), Quaternion.identity);
        Player.NewPlayer.Resources -= S_112_Defence_Gold;// 자원 소비
        
        yield return new WaitForSeconds(5.6f);
        GameObject.FindGameObjectWithTag("Mon_R_ON").GetComponent<Collider>().enabled = true;
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Defence_113()
    {

        GameObject obj = Instantiate(skill_113_Defence, transform.position + new Vector3(0f, 0f, 5f), Quaternion.identity);
        Player.NewPlayer.Resources -= S_113_Defence_Gold;// 자원 소비
        
        yield return new WaitForSeconds(5.6f);
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Defence_120()
    {

        GameObject obj = Instantiate(skill_120_Defence, transform.position + new Vector3(0f, 0f, 5f), Quaternion.identity);
        Player.NewPlayer.Resources -= S_120_Defence_Gold;// 자원 소비
        

        yield return new WaitForSeconds(3.6f);

        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Defence_121()
    {
        //강화 TEXT!
        GameObject obj = Instantiate(skill_121_Defence, transform.position + new Vector3(0f, 0f, 5f), Quaternion.identity);
        Player.NewPlayer.Resources -= S_121_Defence_Gold;// 자원 소비
        obj.transform.parent = GameObject.FindGameObjectWithTag("Win").transform;
        
        yield return new WaitForSeconds(6.6f);
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Defence_122()
    {

        GameObject obj = Instantiate(skill_122_Defence, transform.position + new Vector3(0f, 0f, 5f), Quaternion.identity);
        Player.NewPlayer.Resources -= S_122_Defence_Gold;// 자원 소비
        
        yield return new WaitForSeconds(5.6f);
        Destroy(obj.gameObject);
        yield return null;

    }
    IEnumerator SkillInstant_Defence_123()
    {

        GameObject obj = Instantiate(skill_123_Defence, transform.position + new Vector3(0f, 0f, 5f), Quaternion.identity);
        Player.NewPlayer.Resources -= S_123_Defence_Gold;// 자원 소비
        
        yield return new WaitForSeconds(6.6f);
        Destroy(obj.gameObject);
        yield return null;

    }

    //_S_coolTime__$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

    IEnumerator Skill_100_Attack_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(0).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(0).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_100_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_110_Attack_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(1).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(1).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_110_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_111_Attack_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(2).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(2).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_111_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_112_Attack_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(3).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(3).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_112_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_113_Attack_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(4).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(4).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_113_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_120_Attack_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(5).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(5).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_120_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_121_Attack_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(6).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(6).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_121_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_122_Attack_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(7).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(7).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_122_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_123_Attack_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(8).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(8).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_123_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    //--------SKILL_Defence_CoolTime

    IEnumerator Skill_100_Defence_CoolTime()
    {
        bDF_100_SCool_Ing = true;

        Image S_100_Img = SkillBtn_Load.transform.GetChild(9).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(9).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_100_Defence_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                bDF_100_SCool_Ing = false;
                //S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_110_Defence_CoolTime()
    {
        bDF_110_SCool_Ing = true;

        Image S_100_Img = SkillBtn_Load.transform.GetChild(10).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(10).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_110_Defence_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                bDF_110_SCool_Ing = false;
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_111_Defence_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(11).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(11).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_111_Defence_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_112_Defence_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(12).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(12).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_112_Defence_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_113_Defence_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(13).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(13).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_113_Defence_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_120_Defence_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(14).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(14).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_120_Defence_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_121_Defence_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(15).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(15).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_121_Defence_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_122_Defence_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(16).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(16).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_122_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }

    IEnumerator Skill_123_Defence_CoolTime()
    {
        Image S_100_Img = SkillBtn_Load.transform.GetChild(17).GetComponent<Image>();
        Button S_100_btn = SkillBtn_Load.transform.GetChild(17).GetComponent<Button>();
        S_100_btn.interactable = false;
        S_100_Img.type = Image.Type.Filled;
        float coolTime = 0;

        while (true)
        {
            coolTime += Time.deltaTime;
            S_100_Img.fillAmount = coolTime / S_123_Defence_CoolTime;
            yield return new WaitForEndOfFrame();
            if (S_100_Img.fillAmount >= 1f)
            {
                S_100_btn.interactable = true;
                break;
            }
        }
        yield return null;
    }
    //###################################################################################
    public void GetGetResource(Collider other)
    {
        ani.SetBool("param_idletorunning", false);
        ani.SetBool("param_idletowinpose", true);
        transform.Translate(Vector3.zero);
        Player.NewPlayer.Resources += PlayerGet_InG_Resource_EXP;

        other.gameObject.GetComponent<HUD_Add_Resource>().Obj_Now_Resource -= other.gameObject.GetComponent<HUD_Add_Resource>().Reduce_Amount;
        MsgView_RL.Open_Mineral();
        MsgView_RL.Mineral_msg.text = other.gameObject.GetComponent<HUD_Add_Resource>().Obj_Now_Resource.ToString();

        int s = (Player.NewPlayer.Resources + PlayerGet_InG_Resource_EXP) - Player.NewPlayer.Resources;
        //StartCoroutine(BF_HUDDmgText_AddManager.Draw_Msg("+" + (other.gameObject.GetComponent<HUD_Add_Resource>().Obj_MAX_Resource - other.gameObject.GetComponent<HUD_Add_Resource>().Obj_Now_Resource) + " 골드를 획득하였습니다"));
        BF_UICenter.Draw_Msg_NoMove_ON("+" + (other.gameObject.GetComponent<HUD_Add_Resource>().Obj_MAX_Resource - other.gameObject.GetComponent<HUD_Add_Resource>().Obj_Now_Resource) + " 골드를 획득하였습니다");
        
    }

    public void GetGetResource_End(Collider other)
    {
        ani.SetBool("param_idletowinpose", false);
        MsgView_RL.Close_Mineral();
        MsgView_RL.Mineral_msg.text = "";
        BF_UICenter.Draw_Msg_NoMove_OFF();
        //if (GameObject.FindGameObjectWithTag("Infor_BF").GetComponent<BF_MsgUI_Information_Manager>().Mineral_msg.text != "")
        //    GameObject.FindGameObjectWithTag("Infor_BF").GetComponent<BF_MsgUI_Information_Manager>().Mineral_msg.text = "";

    }
    

    //UPDATE*****************************
    void Check_HUD_AorD_ToUpdate()
    {
        
        if ( Player.NewPlayer.IsATKDEF_12 ==1)
        {
            
            StartCoroutine(UpdateHUDstate_A());
            
        }

        if( Player.NewPlayer.IsATKDEF_12 == 2)
        {
            
            StartCoroutine(UpdateHUDstate_D());
            
        }           

    }

    IEnumerator UpdateHUDstate_A()
    {

        while (true)
        {
            Draw_Level();
            Draw_HP();
            Draw_EXP();
            yield return null;
        }
        
    }

    IEnumerator UpdateHUDstate_D()
    {

        while (true)
        {
            HUDs[0].text = "";
            Draw_HP();
            Draw_Resources();
            yield return null;
        }
       
    }

    void Draw_Level()
    {
        //Debug.Log(LvValue.ToString()+ "P");
        HUDs[0].text = Player.NewPlayer.playerIngameLevel.ToString();
        
    }
    void Draw_HP()
    {

        //Debug.Log(hpvalue + "/" + MAXhp+ "P");
        HUDs[1].text = Player.NewPlayer.CurrentHP.ToString() + "/" +  Player.NewPlayer.MaxHP.ToString();
        HUDs[1].color = Color.white;
        if (Player.NewPlayer.CurrentHP <= 0)
        {
            GameObject.Find("0.BattleFieldManager").GetComponent<InforBF_Manager>().Lose();
            transform.localPosition = new Vector3(0f, 600f, 0f);
            
            return;
        }
    }
    void Draw_EXP()
    {

        //Debug.Log(ExpValue.ToString() + ": EXP P");
        HUDs[2].text = Player.NewPlayer.CurrentEXP.ToString() + "/" + Player.NewPlayer.RequirEXP.ToString();
        if (Player.NewPlayer.CurrentEXP >= Player.NewPlayer.RequirEXP)
        {
            Player.NewPlayer.playerIngameLevel += 1;
            Player.NewPlayer.CurrentEXP = 0;
            SetDrawHUD();

            LVUP_Point += 1;
            CheckSkillUp();
            
        }
        
    }
    void Draw_Resources()
    {
        HUDs[2].text = "자원 : "+Player.NewPlayer.Resources.ToString();
        
    }

    void CheckSkillUp()
    {
        if(LVUP_Point > 0)
        {
            if (Player.NewPlayer.playerMtype != 0)
                SkillBtn_Load.transform.GetChild(18).gameObject.SetActive(true);
            if (Player.NewPlayer.playerMtype != 0 && Player.NewPlayer.playerMtype != 100)
                SkillBtn_Load.transform.GetChild(19).gameObject.SetActive(true);
            if (Player.NewPlayer.playerMtype != 0 && Player.NewPlayer.playerMtype != 100 && Player.NewPlayer.playerMtype != 110 && Player.NewPlayer.playerMtype != 120)
                SkillBtn_Load.transform.GetChild(20).gameObject.SetActive(true);
        }

    }



    void SetDrawHUD()
    {
        Player.NewPlayer.MaxHP = BaseHP + Player.NewPlayer.playerIngameLevel * 100;
        Player.NewPlayer.CurrentHP = Player.NewPlayer.MaxHP;

        Player.NewPlayer.RequirEXP = Player.NewPlayer.playerIngameLevel * 200;

        Player.NewPlayer.Player_MainMaxEXP = Player.NewPlayer.playerLevel * 150;
    }

    
    
}
