using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Add_Resource : MonoBehaviour {

    //public Camera UI_Camera;        //HUD POS TRANS
    //public GameObject HUD;
    //public GameObject HUDCamPos;

    public GameObject HudDmg_Text;  // HUD DMG TEXT
    public Color Set_Color;

    //private Text HUDs; // HUD TEXT
    //Text Information_Text;

    public int Obj_MAX_Resource;
    public int Obj_Now_Resource = 0;

    public int Random_Resource_Value;

    public int Reduce_Amount = 1;

    void Start()
    {
        //ParentFind_DmgText = transform.GetChild(0).transform; //#######
        //HUDs = transform.GetChild(0).GetComponentInChildren<Text>();

        Start_Resource_Set();

    }

    void Update()
    {
        Obj_Empty();
        //Rendering_Bar();
        //Draw_HP();
    }

    private void LateUpdate()
    {
        //ScreenToWorld();
    }

    void Obj_Empty()
    {
        if (Obj_Now_Resource <= 0)
        {
            this.transform.parent.gameObject.SetActive(false);//부모위치 끄기 리스폰 위치     
            
            GameObject.FindGameObjectWithTag("Infor_BF").transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
            Destroy(this.gameObject);
            GameObject.FindGameObjectWithTag("Cha").GetComponent<IG_MainPlayer>().ani.SetBool("param_idletowinpose", false);
            BF_UICenter.Draw_Msg_NoMove_OFF();
            return;
        }
    }

    private void OnTriggerEnter(Collider other)
    {        
        int Tmp_HP = 0;
        Tmp_HP = Obj_Now_Resource;
        if (other.tag == "Cha_R")
        {
            Obj_Now_Resource = Tmp_HP;
        }

        /*if (other.tag == "Skill_100")
        {
            Obj_Now_HP -= Reduce_Dmg_Amount;
            StartCoroutine(Draw_DMG_AI(Reduce_Dmg_Amount));
        }*/
    }

    void Start_Resource_Set()
    {
        Random_Resource_Value = Random.Range(1000, 5000);
        Obj_MAX_Resource = Random_Resource_Value;
        Obj_Now_Resource = Obj_MAX_Resource;
        if (Obj_MAX_Resource < 1600)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (Obj_MAX_Resource < 3200 && Obj_MAX_Resource >= 1600)
        {
            transform.localScale = new Vector3(2f, 2f, 2f);
        }
        if (Obj_MAX_Resource <= 5000 && Obj_MAX_Resource >= 3200)
        {
            transform.localScale = new Vector3(3f, 3f, 3f);
        }

    }

    public IEnumerator Draw_DMG_Building(int InputDMG)
    {

        GameObject ta = Instantiate(HudDmg_Text);
        ta.GetComponent<Text>().text = InputDMG.ToString();
        ta.GetComponent<Text>().color = Set_Color;
        ta.GetComponent<Text>().resizeTextForBestFit = true;
        yield return new WaitForSeconds(0.8f);
        Destroy(ta.gameObject);

    }
}
    /*
    void ScreenToWorld()
    {
        Vector3 HUD_POS;
        HUD_POS = HUDCamPos.transform.position;
        Vector3 screenPos = UI_Camera.WorldToScreenPoint(HUD_POS);
        Vector3 viewPos = UI_Camera.ScreenToViewportPoint(screenPos);
        Vector3 worldpos = UI_Camera.ViewportToWorldPoint(viewPos);

        HUD.transform.position = worldpos;
    }

    void Rendering_Bar()
    {
        float GetHP = (float)Obj_Now_Resource * 0.001f;

        HUD.transform.FindChild("Health_BackBar").FindChild("Health_Bar").transform.localScale = new Vector3(GetHP, 1f, 1f);                
    }   

    
    void Draw_HP()
    {
        HUDs.text = Obj_Now_Resource.ToString();        
    }
    
}*/
