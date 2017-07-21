using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InforCreateCha_Manager : MonoBehaviour {

    public InputField inf;
    private Button btn_01;
    // Use this for initialization
    private void Start()
    {
        SetNewPlayer();
        btn_01 = GameObject.Find("Male_Tall").GetComponent<Button>();
    }


    public void Select_PlayerSpeciesType_1()
    {
        UserInformation.Instance.SPECIESTYPE = 1;
        Debug.Log("SAVE STYPE : "+ UserInformation.Instance.SPECIESTYPE);
    }
    public void Select_PlayerSpeciesType_2()
    {
        UserInformation.Instance.SPECIESTYPE = 2;
        Debug.Log("SAVE STYPE : " + UserInformation.Instance.SPECIESTYPE);
    }
    public void Select_PlayerSpeciesType_3()
    {
        UserInformation.Instance.SPECIESTYPE = 3;
        Debug.Log("SAVE STYPE : " + UserInformation.Instance.SPECIESTYPE) ;
    }
    public void Select_PlayerSpeciesType_4()
    {
        UserInformation.Instance.SPECIESTYPE = 4;
        Debug.Log("SAVE STYPE : " + UserInformation.Instance.SPECIESTYPE);
    }
    public void Save_PlayerNewName()
    {
        UserInformation.Instance.USERNAME = inf.text;
        Debug.Log("SAVE NAME : " + UserInformation.Instance.USERNAME);
    }

    private void SetNewPlayer()
    {
        UserInformation.Instance.USERLEVEL = 1;
        UserInformation.Instance.MODELTYPE = 0;
        UserInformation.Instance.SKILLUPPOINT = 0;
    }
}
