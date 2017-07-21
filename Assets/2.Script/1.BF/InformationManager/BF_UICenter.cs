using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BF_UICenter : MonoBehaviour {

    public static GameObject HudDmg_Text;
    static Transform Parent_P;
    static Transform Parent_AI;

    // Use this for initialization
    void Start () {
        HudDmg_Text = transform.GetChild(4).gameObject;
        Parent_P = GameObject.FindGameObjectWithTag("Cha").transform.GetChild(5).transform;
        Parent_AI = GameObject.FindGameObjectWithTag("Mon").transform.GetChild(3).transform;
        //Parent_EXPMON = GameObject.FindGameObjectWithTag("ExpMon_Body").transform.GetChild(5).transform;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static IEnumerator Draw_DMG_Player(int InputDMG)
    {
        GameObject tp = Instantiate(HudDmg_Text, Parent_P);
        tp.GetComponent<Text>().text = InputDMG.ToString();
        tp.GetComponent<Text>().color = Color.red;
        tp.GetComponent<Text>().resizeTextForBestFit = true;
        yield return new WaitForSeconds(0.8f);
        Destroy(tp.gameObject);

    }

    public static IEnumerator Draw_DMG_AI(int InputDMG)
    {
        GameObject tp = Instantiate(HudDmg_Text, Parent_AI);
        tp.GetComponent<Text>().text = InputDMG.ToString();
        tp.GetComponent<Text>().color = Color.yellow;
        tp.GetComponent<Text>().resizeTextForBestFit = true;
        yield return new WaitForSeconds(0.8f);
        Destroy(tp.gameObject);

    }    

    public static void Draw_Msg_MoveUp(string InputMsg)
    {
        GameObject.FindGameObjectWithTag("Msg").GetComponent<BF_UI_MSG_Information_Manager>().Msg_TextBox_MoveUp(InputMsg);
    }
    public static void Draw_Msg_Balloon(string InputMsg)
    {
        GameObject.FindGameObjectWithTag("Msg").GetComponent<BF_UI_MSG_Information_Manager>().Msg_TextBox_Balloon(InputMsg);
    }


    public static void Draw_Msg_NoMove_ON(string InputMsg)
    {
        GameObject.FindGameObjectWithTag("Msg").GetComponent<BF_UI_MSG_Information_Manager>().Msg_TextBox_NoMove_ON(InputMsg);
    }
    public static void Draw_Msg_NoMove_OFF()
    {
        GameObject.FindGameObjectWithTag("Msg").GetComponent<BF_UI_MSG_Information_Manager>().MSG_TextBox_NoMove_OFF();
    }
    
}
