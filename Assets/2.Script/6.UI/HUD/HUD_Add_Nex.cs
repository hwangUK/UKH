using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Add_Nex : MonoBehaviour {

    public Camera UI_Camera;        //HUD POS TRANS
    public GameObject HUD;
    public GameObject HUDCamPos;

    public GameObject HudDmg_Text;  // HUD DMG TEXT
    private Transform ParentFind_DmgText;
    public Color Set_Color;

    private Text[] HUDs; // HUD TEXT

    public int Obj_Now_MaxHp = 100;
    private int Obj_Now_HP;
    

    public int ReduceDmgAmount_Mon;
    public int ReduceDmgAmount_Cha;

    public int ReduceDmgAmount_Skill_100;
    public int ReduceDmgAmount_Skill_110;
    public int ReduceDmgAmount_Skill_111;
    public int ReduceDmgAmount_Skill_112;
    public int ReduceDmgAmount_Skill_113;
    public int ReduceDmgAmount_Skill_120;
    public int ReduceDmgAmount_Skill_121;
    public int ReduceDmgAmount_Skill_122;
    public int ReduceDmgAmount_Skill_123;


    //public int HP_NextUp_Amount;
    //public int Exp_NextUp_Amount;



    void Start () {
        Obj_Now_HP = Obj_Now_MaxHp;
        ParentFind_DmgText = transform.GetChild(2).transform; //#######
        HUDs = transform.GetChild(2).GetComponentsInChildren<Text>();
        SetDrawHUD();
    }
	
	void Update () {
        
    }

    private void LateUpdate()
    {
        Rendering_Bar();
        Draw_HP();
        ScreenToWorld();
    }



    void ScreenToWorld()
    {
        Vector3 HUD_POS;
        HUD_POS = HUDCamPos.transform.position;
        Vector3 screenPos = Camera.main.WorldToScreenPoint(HUD_POS);
        Vector3 viewPos = Camera.main.ScreenToViewportPoint(screenPos);
        Vector3 worldpos = UI_Camera.ViewportToWorldPoint(viewPos);

        HUD.transform.position = worldpos;
    }

    void Rendering_Bar()
    {
        float GetHP = (float)Obj_Now_HP / Obj_Now_MaxHp;

        HUD.transform.FindChild("Health_BackBar").FindChild("Health_Bar").transform.localScale = new Vector3(GetHP, 1f, 1f);
    }
    
    void Draw_HP()
    {
        
        HUDs[1].text = Obj_Now_HP.ToString() + "/" + Obj_Now_MaxHp.ToString();
        if (Obj_Now_HP <= 0)
        {
            if(Player.NewPlayer.IsATKDEF_12 == 1)
            {
                GameObject.Find("0.BattleFieldManager").GetComponent<InforBF_Manager>().Win();
            }
            else
                GameObject.Find("0.BattleFieldManager").GetComponent<InforBF_Manager>().Lose();
            
        }
    }
    
    void SetDrawHUD()
    {       
        
        Obj_Now_HP = Obj_Now_MaxHp;       

        //Player.NewPlayer.Player_MainMaxEXP = Player.NewPlayer.playerLevel * 150;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mon_Atk" && Player.NewPlayer.IsATKDEF_12 == 2)
        {
            Obj_Now_HP -= ReduceDmgAmount_Mon;
            StartCoroutine( GameInformation.SYS_MSG2("본진이 적에게 공격받고있습니다", 4f));
            StartCoroutine(Draw_DMG_Building(ReduceDmgAmount_Mon));
        }

        if (other.tag == "Cha_Atk" && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            Obj_Now_HP -= ReduceDmgAmount_Cha;
            StartCoroutine(Draw_DMG_Building(ReduceDmgAmount_Cha));
        }
        if (other.tag == "Skill_100" && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            Obj_Now_HP -= ReduceDmgAmount_Skill_100;
            StartCoroutine(Draw_DMG_Building(ReduceDmgAmount_Skill_100));
        }

        if (other.tag == "Skill_110" && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            Obj_Now_HP -= ReduceDmgAmount_Skill_110;
            StartCoroutine(Draw_DMG_Building(ReduceDmgAmount_Skill_110));
        }
        if (other.tag == "Skill_111" && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            Obj_Now_HP -= ReduceDmgAmount_Skill_111;
            StartCoroutine(Draw_DMG_Building(ReduceDmgAmount_Skill_111));
        }
        if (other.tag == "Skill_112" && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            Obj_Now_HP -= ReduceDmgAmount_Skill_112;
            StartCoroutine(Draw_DMG_Building(ReduceDmgAmount_Skill_112));
        }
        if (other.tag == "Skill_113" && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            Obj_Now_HP -= ReduceDmgAmount_Skill_113;
            StartCoroutine(Draw_DMG_Building(ReduceDmgAmount_Skill_113));
        }
        if (other.tag == "Skill_120" && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            Obj_Now_HP -= ReduceDmgAmount_Skill_120;
            StartCoroutine(Draw_DMG_Building(ReduceDmgAmount_Skill_120));
        }
        if (other.tag == "Skill_121" && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            Obj_Now_HP -= ReduceDmgAmount_Skill_121;
            StartCoroutine(Draw_DMG_Building(ReduceDmgAmount_Skill_121));
        }
        if (other.tag == "Skill_122" && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            Obj_Now_HP -= ReduceDmgAmount_Skill_122;
            StartCoroutine(Draw_DMG_Building(ReduceDmgAmount_Skill_122));
        }
        if (other.tag == "Skill_123" && Player.NewPlayer.IsATKDEF_12 == 1)
        {
            Obj_Now_HP -= ReduceDmgAmount_Skill_123;
            StartCoroutine(Draw_DMG_Building(ReduceDmgAmount_Skill_123));
        }
        
    }



    public IEnumerator Draw_DMG_Building(int InputDMG)
    {

        GameObject ta = Instantiate(HudDmg_Text, ParentFind_DmgText.transform);
        ta.GetComponent<Text>().text = InputDMG.ToString();
        ta.GetComponent<Text>().color = Set_Color;
        ta.GetComponent<Text>().resizeTextForBestFit = true;
        yield return new WaitForSeconds(0.8f);
        Destroy(ta.gameObject);

    }
}
