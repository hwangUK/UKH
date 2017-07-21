using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Defence_HP : MonoBehaviour {

    public int HP = 10;
    // Use this for initialization
    public Text t;
    private BF_UI_RL_Information_Manager Msg_UI;


    private void Start()
    {
        Msg_UI = GameObject.FindGameObjectWithTag("Infor_BF").GetComponent<BF_UI_RL_Information_Manager>();
    }

    private void Update()
    {
        t.text = HP.ToString();

        if (HP <= 1)
            Destroy(this.gameObject);

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Mon_Atk")
        {
            HP -= 1;

            Msg_UI.Open_Defence_Build();
            Msg_UI.DefenceBuild_msg.text = HP.ToString();


            if (HP <= 1)
            {
                GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().target = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>().TargetDefult;
                Destroy(this.gameObject);
                Msg_UI.Close_Defence_Build();
                Msg_UI.DefenceBuild_msg.text = "";
            }            
        }        

    }
}
