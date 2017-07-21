using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button_Manager : MonoBehaviour {

    public ParticleSystem ptk_BaseAtk;
	IG_MainPlayer P;
    public bool bGET_UPgrade = false;
    public bool bGET_Base = false;
    public bool bGetOnBtn_Check = false;

    Image img_Get;

    Color color_GetBtnImage;
    

    void Start () {
        P = GetComponent<IG_MainPlayer> ();

        img_Get = transform.GetChild(6).transform.GetChild(8).GetComponent<Image>();
        color_GetBtnImage = img_Get.color;
        
    }
       

	public void GetOn()
    {
        color_GetBtnImage.a = 1f;
        img_Get.color = color_GetBtnImage;

        bGET_Base = true;

        if (P.bSkill_DF_100 == true){
            bGET_UPgrade = true;
        }             
	}

	public void GetOFF(){
        color_GetBtnImage.a = 0.5f;
        img_Get.color = color_GetBtnImage;
        bGET_Base = false;
        bGET_UPgrade = false;
    }

	public void AtkOn(){
        P.IsAtk = true;
        StartCoroutine(ATK_DMG());
    }

	public void AtkOff(){
        P.IsAtk = false;
        this.transform.GetChild(7).GetComponent<Collider>().transform.localScale = new Vector3(0f, 0f, 0f);
    }

	public void ULdown()
	{

        P.bButtonUL = true;
	}
	public void ULup()
	{
        P.bButtonUL = false;
	}

	public void URdown()
	{
        P.bButtonUR = true;
	}
	public void URup()
	{
        P.bButtonUR = false;
	}

	public void DRdown()
	{
        P.bButtonDR = true;
	}
	public void DRup()
	{
		P.bButtonDR = false;
	}
	public void DLdown()
	{
        P.bButtonDL = true;
	}
	public void DLup()
	{
        P.bButtonDL = false;
	}

	public void Udown()
	{
        P.bButtonU = true;
	}
	public void Uup(){
        P.bButtonU = false;
	}

	public void Ddown()
	{
        P.bButtonD = true;
	}
	public void Dup()
	{
        P.bButtonD = false;
	}

	public void LeftDown()
	{
        P.bButtonL = true;
	}
	public void LeftUp()
	{
        P.bButtonL = false;
	}

	public void RightDown()
	{
        P.bButtonR = true;
	}
	public void RightUp()
	{
        P.bButtonR = false;
	}

    IEnumerator ATK_DMG()
    {
        this.transform.GetChild(7).gameObject.SetActive(true);
        this.transform.GetChild(7).GetComponent<Collider>().transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
        this.transform.GetChild(7).GetComponent<Collider>().transform.localPosition = new Vector3(0f, 1.3f, 1.3f);
        ParticleSystem ps= Instantiate(ptk_BaseAtk, this.transform.GetChild(7).GetComponent<Collider>().transform);
        ps.transform.localPosition = new Vector3(0f, 0.5f, 0.1f);
        ps.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        yield return new WaitForSeconds(1f);
        this.transform.GetChild(7).GetComponent<Collider>().transform.localScale = new Vector3(0f, 0f, 0f);
        Destroy(ps.gameObject);
        this.transform.GetChild(7).gameObject.SetActive(false);
        yield return null;
    }

    
}
