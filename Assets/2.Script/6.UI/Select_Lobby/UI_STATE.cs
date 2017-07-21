using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_STATE : MonoBehaviour {

	private Text[] UItext;

	// Use this for initialization
	void Start () {
		UItext = GetComponentsInChildren<Text>();
		SettingStateUI ();
	}
    
	void SettingStateUI(){

		UItext[0].text = "NAME  : " + Player.NewPlayer.playerName;
		UItext[1].text = "CLASS : " + Player.NewPlayer.playerMtype;
		UItext[2].text = "LEVEL : " + Player.NewPlayer.playerLevel;
		UItext [3].text = "EXP   : " + Player.NewPlayer.CurrentEXP + " / " + Player.NewPlayer.RequirEXP;
		UItext[4].text = "HP    : " + Player.NewPlayer.MaxHP;
		UItext[5].text = "MP    : " + Player.NewPlayer.MaxMP;
		UItext[6].text = "STR   : " + Player.NewPlayer.Str;
		UItext[7].text = "INT   : " + Player.NewPlayer.Int;
		UItext[8].text = "DEF   : " + Player.NewPlayer.Def;
		UItext[9].text = "MR    : " + Player.NewPlayer.Mr;
		UItext[10].text = "VIT   : "+ Player.NewPlayer.Vit;
        UItext[11].text = "SKILL 1";  
		UItext[12].text = "SKILL 2";
        UItext[13].text = "SKILL 3"; 
	}
		
}
