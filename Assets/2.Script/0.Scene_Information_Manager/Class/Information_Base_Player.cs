using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Information_Base_Player
{
	//-------------- USER SETTING STATUS
	private int _IsFirst =0;
    private int _IsAtkDef_12 = 1;
    //private int _NowStage = 1;

    private string PlayerName = "NONAME";
	private int _playerLevel = 0;
    private int _playerMain_CurrentExp = 0;
    private int _playerMain_MAXExp = 0;
    private int _PlayerSpeciesType = 0;
    
    private int _Mtype = 0;
    private int _skillUPPoint = 0;
    private int _winLose = 0;

    private int _stage01 = 0;
    private int _stage02 = 0;
    private int _stage03 = 0;
    private int _stage04 = 0;
    private int _stage05 = 0;
    private int _stage06 = 0;
    private int _stage07 = 0;
    private int _stage08 = 0;
    private int _stage09 = 0;
    private int _stage10 = 0;
    private int _stage11 = 0;
    private int _stage12 = 0;
    private int _stage13 = 0;
    private int _stage14 = 0;
    private int _stage15 = 0;
    private int _stage16 = 0;
    private int _stage17 = 0;
    private int _stage18 = 0;
    private int _stage19 = 0;
    private int _stage20 = 0;
    private int _stage21 = 0;
    private int _stage22 = 0;
    private int _stage23 = 0;
    private int _stage24 = 0;
    private int _stage25 = 0;
    private int _stage26 = 0;
    private int _stage27 = 0;
    private int _stage28 = 0;
    private int _stage29 = 0;
    private int _stage30 = 0;
    private int _stage31 = 0;
    private int _stage32 = 0;


    //INGAME SETTING----------------------------
    private int _In_playerIngameLevel = 0;
	private int _In_maxHP =0;
	private int _In_currentHP =0;
	private int _In_maxMP = 0;

	private int _RequirExp = 0;
	private int _CurrentExp = 0;
	private int _GetExp =0;

	private int _In_str =0;
	private int _In_int =0;

	private int _In_def =0;
	private int _In_mr =0;

	private int _In_vit =0;
    private int _Resources = 0;

    //USER SETTING STATUS---------------------------------------

    public int IsFirst{get{return _IsFirst;}set{_IsFirst = value;}}
    public string playerName{ get { return PlayerName; } set { PlayerName = value; } }
	public int playerLevel{ get { return _playerLevel; } set { _playerLevel = value; } }
    public int playerMtype { get { return _Mtype; } set { _Mtype = value; } }
    public int PlayerSkillUpPoint { get { return _skillUPPoint; }set { _skillUPPoint = value; } }
    public int PlayerSpeciesType { get { return _PlayerSpeciesType; } set { _PlayerSpeciesType = value; } }
    public int Player_MainCurrentEXP { get { return _playerMain_CurrentExp; } set { _playerMain_CurrentExp = value; } }
    public int Player_MainMaxEXP { get { return _playerMain_MAXExp; } set { _playerMain_MAXExp = value; } }
    public int IsATKDEF_12 { get { return _IsAtkDef_12; } set { _IsAtkDef_12 = value; } }
    //public int IsNowStage { get { return _NowStage; } set { _NowStage = value; } }

    public int STAGE_01 { get { return _stage01; } set { _stage01 = value; } }
    public int STAGE_02 { get { return _stage02; } set { _stage02 = value; } }
    public int STAGE_03 { get { return _stage03; } set { _stage03 = value; } }
    public int STAGE_04 { get { return _stage04; } set { _stage04 = value; } }
    public int STAGE_05 { get { return _stage05; } set { _stage05 = value; } }
    public int STAGE_06 { get { return _stage06; } set { _stage06 = value; } }
    public int STAGE_07 { get { return _stage07; } set { _stage07 = value; } }
    public int STAGE_08 { get { return _stage08; } set { _stage08 = value; } }
    public int STAGE_09 { get { return _stage09; } set { _stage09 = value; } }
    public int STAGE_10 { get { return _stage10; } set { _stage10 = value; } }
    public int STAGE_11 { get { return _stage11; } set { _stage11 = value; } }
    public int STAGE_12 { get { return _stage12; } set { _stage12 = value; } }
    public int STAGE_13 { get { return _stage13; } set { _stage13 = value; } }
    public int STAGE_14 { get { return _stage14; } set { _stage14 = value; } }
    public int STAGE_15 { get { return _stage15; } set { _stage15 = value; } }
    public int STAGE_16 { get { return _stage16; } set { _stage16 = value; } }
    public int STAGE_17 { get { return _stage17; } set { _stage17 = value; } }
    public int STAGE_18 { get { return _stage18; } set { _stage18 = value; } }
    public int STAGE_19 { get { return _stage19; } set { _stage19 = value; } }
    public int STAGE_20 { get { return _stage20; } set { _stage20 = value; } }
    public int STAGE_21 { get { return _stage21; } set { _stage21 = value; } }
    public int STAGE_22 { get { return _stage22; } set { _stage22 = value; } }
    public int STAGE_23 { get { return _stage23; } set { _stage23 = value; } }
    public int STAGE_24 { get { return _stage24; } set { _stage24 = value; } }
    public int STAGE_25 { get { return _stage25; } set { _stage25 = value; } }
    public int STAGE_26 { get { return _stage26; } set { _stage26 = value; } }
    public int STAGE_27 { get { return _stage27; } set { _stage27 = value; } }
    public int STAGE_28 { get { return _stage28; } set { _stage28 = value; } }
    public int STAGE_29 { get { return _stage29; } set { _stage29 = value; } }
    public int STAGE_30 { get { return _stage30; } set { _stage30 = value; } }
    public int STAGE_31 { get { return _stage31; } set { _stage31 = value; } }
    public int STAGE_32 { get { return _stage32; } set { _stage32 = value; } }


    //INGAME SETTING-------------------------------------------

    public int playerIngameLevel{ get{ return _In_playerIngameLevel; } set { _In_playerIngameLevel = value; } }
	public int MaxHP{ get { return _In_maxHP; } set { _In_maxHP = value; } }
	public int MaxMP{ get { return _In_maxMP; } set { _In_maxMP = value; } }
	public int Str{ get { return _In_str; } set { _In_str = value; } }
	public int Def{ get { return _In_def; } set { _In_def = value; } }
	public int Mr{ get { return _In_mr; } set { _In_mr = value; } }
	public int Int{ get { return _In_int; } set { _In_int = value; } }
	public int Vit{ get { return _In_vit; } set { _In_vit = value; } }
	public int CurrentHP{ get { return _In_currentHP; } set { _In_currentHP = value; } }
    public int IsWinLose { get { return _winLose; } set { _winLose = value; } }

    public int CurrentEXP{get{return _CurrentExp; }set{ _CurrentExp = value;}}
	public int RequirEXP{ get { return _RequirExp; } set { _RequirExp = value; } }
	public int GetEXP{ get { return _GetExp; } set { _GetExp = value; } }

    public int Resources { get { return _Resources; } set { _Resources = value; } }



}