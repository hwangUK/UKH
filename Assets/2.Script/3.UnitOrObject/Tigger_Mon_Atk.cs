using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tigger_Mon_Atk : MonoBehaviour {

    IG_MainAI AI;

    private void Start()
    {
        AI = GameObject.Find("Robot Kyle").GetComponent<IG_MainAI>();
        GetComponent<Collider>().enabled = false;      
    }

    private void Update()
    {
        if(AI.IsATK == true)
        {
            GetComponent<Collider>().enabled = true;
            
        }
        else
            GetComponent<Collider>().enabled = false;
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if(AI.IsATK == true)
        {
            AI.transform.LookAt(other.transform);
        }

        if(other.tag == "Cha")
        {
            Player.NewPlayer.CurrentHP -= AI.Player_ReduceHP;
            StartCoroutine(AI.Draw_DMG_Player(AI.Player_ReduceHP));
            //Debug.Log("Find Cha = Reduce PlayerHP");
        }
    }


}
