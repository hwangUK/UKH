using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ExpMon_R : MonoBehaviour
{

    Animator anim;
    NavMeshAgent nav;
    
    Transform TarGetDefault;
    Transform nowTarget;

    public Collider ATK_Col;

    bool bFind = false;

    public string Distance = "";

    public bool FIND_CHA = false;
    public bool FIND_AI = false;
    // Use this for initialization
    void Start()
    {
        anim = gameObject.transform.parent.GetComponent<Animator>();
        nav = gameObject.transform.parent.GetComponent<NavMeshAgent>();
        TarGetDefault = transform.parent.transform;
        //nav = GetComponent<NavMeshAgent>();
        ATK_Col.enabled = false;
        nowTarget = TarGetDefault;
    }


    private void Update()
    {
        GoStop();
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cha")
        {
            FIND_CHA = true;
            bFind = true;
            nowTarget = other.transform;
            GetComponent<Collider>().enabled = false;
            // Debug.Log(other.tag);


        }
        else if (other.gameObject.tag == "Mon")
        {
            FIND_AI = true;
            bFind = true;
            nowTarget = other.transform;
            GetComponent<Collider>().enabled = false;
            // Debug.Log(other.tag);

        }
    }

    //u

    void GoStop()
    {
        Distance = Vector3.Distance(nowTarget.position, transform.position).ToString();
        // Debug.Log(Vector3.Distance(nowTarget.position, transform.position));
        //Debug.Log(nowTarget);

        if (Vector3.Distance(nowTarget.position, transform.position) >= 40f)
        {
            ATK_Col.enabled = false;
            nowTarget = TarGetDefault;
            GetComponent<Collider>().enabled = true;
            bFind = false;
            FIND_AI = false;
            FIND_CHA = false;
        }

        if (Vector3.Distance(nowTarget.position, transform.position) >= 10.5f && bFind == true)
        {
            ATK_Col.enabled = false;
            NavGo();
        }

        else if (Vector3.Distance(nowTarget.position, transform.position) < 10.5f)
        {
            NavStop();
            if(nowTarget != TarGetDefault)
                anim.SetBool("IsAtk", true);
            ATK_Col.enabled = true;               
        }
    }
	
	void NavGo()
    {
         nav.enabled = true;
         nav.destination = nowTarget.position;
         anim.SetBool("IsAtk", false);
         anim.SetBool("IsRun", true);
    }

    void NavStop()
    {
         nav.enabled = false;
         anim.SetBool("IsRun", false);
         anim.SetBool("IsAtk", false);
    }
   
   

}