using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree_Open : MonoBehaviour {

    	
    public void START_SKILL_OPEN()
    {
        this.gameObject.SetActive(true);
    }
    public void END_SKILL_CLOSE()
    {
       this.gameObject.SetActive(false);
    }
   
}
