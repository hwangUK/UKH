using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Infor_TStoryManager : MonoBehaviour {

    public Text StoryText;


    private Text InputText_00;    
    public int HowManyCount = 1;

    private Text InputText_01;
    private Text InputText_02;
    private Text InputText_03;
    private Text InputText_04;
    private Text InputText_05;
    private Text InputText_06;
    private Text InputText_07;
    private Text InputText_08;
    private void Awake()
    {
        GameInformation.SYS_MSG("", 5f);
    }
    // Use this for initialization
    void Start () {
        InputText_00 = GetComponent<Text>();                
        InputText_01 = transform.GetChild(1).GetComponent<Text>();
        InputText_02 = transform.GetChild(2).GetComponent<Text>();
        InputText_03 = transform.GetChild(3).GetComponent<Text>();
        InputText_04 = transform.GetChild(4).GetComponent<Text>();
        InputText_05 = transform.GetChild(5).GetComponent<Text>();
        InputText_06 = transform.GetChild(6).GetComponent<Text>();
        InputText_07 = transform.GetChild(7).GetComponent<Text>();
        InputText_08 = transform.GetChild(8).GetComponent<Text>();

        StartCoroutine(RunningText(InputText_00.text));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator RunningText(string msg)
    {
        // 1번 이야기
        char[] cha = msg.ToCharArray();
        
        for (int i = 0; i < cha.Length; i++)
        {
            StoryText.text += cha[i].ToString();
            yield return new WaitForSeconds(0.15f);
        }
        yield return new WaitForSeconds(2f);
        StoryText.text = "";

        //// 2번 이야기
        char[] cha1 = InputText_01.text.ToCharArray();
        for (int i = 0; i < cha1.Length; i++)
        {
            StoryText.text += cha1[i].ToString();
            yield return new WaitForSeconds(0.15f);
        }
        yield return new WaitForSeconds(2f);
    }
}
