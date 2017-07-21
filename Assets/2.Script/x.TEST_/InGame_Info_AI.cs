using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame_Info_AI : Information_Base_Player {
	//서버에서 성향정보받아옴


	public void CreateInGamePlayer(){
		Information_Base_Player InCha;
		InCha = new Information_Base_Player ();
		InCha.playerName = "";
		InCha.playerLevel = 1;
		InCha.MaxHP = 100;
		InCha.MaxMP = 120;
		InCha.Str = 5;
		InCha.Int = 10;
		InCha.Def = 15;
		InCha.Mr = 20;
		InCha.Vit = 1000;
		//+ 성향정보
	}


}
