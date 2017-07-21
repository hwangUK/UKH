using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_DF_100 : MonoBehaviour {

    IG_MainPlayer P;
    
	void Start () {
        P = transform.parent.GetComponent<IG_MainPlayer>();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Resource" && transform.parent.GetComponent<UI_Button_Manager>().bGET_UPgrade == true)
        {
            P.GetGetResource(other);
        }

        else if(other.gameObject.tag == "Resource" && transform.parent.GetComponent<UI_Button_Manager>().bGET_UPgrade == false)
        {
            P.GetGetResource_End(other);
        }
    }
    
}
