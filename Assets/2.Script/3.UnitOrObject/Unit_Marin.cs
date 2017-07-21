using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Unit_Marin : MonoBehaviour {

    NavMeshAgent Nav;
    Transform Target;
    Animation ani;
    IG_MainAI AI;

    public int Health = 10;
    public int GetDmg_MonAtk = 1;

    // Use this for initialization
    void Start () {
        AI = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>();
        Nav = GetComponent<NavMeshAgent>();
        Target = GameObject.FindGameObjectWithTag("Mon").transform;
        ani = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update() {
        
	    if(Vector3.Distance(transform.position,Target.position) <= 10f)
        {            
            StartCoroutine(Attack());
        }
        else
        {            
            Go();
        }

	    if (Health <= 0) {
		    Death ();
	    }
    }
    void OnTriggerEnter(Collider other){

	    if(other.gameObject.tag == "Mon_Atk")
        {
            Health -= GetDmg_MonAtk;
        }
    }   
    void Go()
    {
        Nav.enabled = true;
        Nav.destination = Target.position;
        ani.GetClip("Walk");
    }
    IEnumerator Attack(){
        transform.GetChild(2).gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        transform.GetChild(2).gameObject.SetActive(false);
        Nav.enabled = false;
        ani.GetClip("Attack");	
    }

    void Death (){
        GameInformation.Mon_R_ColOn();
        Mon_R_ON.TARGET = Mon_R_ON.Target_D;
        Destroy(this.gameObject);
    }
}
