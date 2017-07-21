using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill121 : MonoBehaviour {
    IG_MainAI IGA;
    int RandomStrongNum;
    Text RanText;
    GameObject Gob_RanText;

	// Use this for initialization
	void Start () {

        IGA = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>();
        RanText = transform.GetChild(0).GetComponent<Text>();
        Gob_RanText = transform.GetChild(0).gameObject;

        StartCoroutine(SkillStrong121());
        
	}
	

    IEnumerator SkillStrong121()
    {
        RandomStrongNum = (int)Random.Range(20f, 60f);
        
        Gob_RanText.SetActive(true);

        if(RandomStrongNum > 30)
        {
            RanText.text = "골렘 강화 성공!!  +" + RandomStrongNum.ToString();
            IGA.SkillDMG_120 += RandomStrongNum;
            yield return new WaitForSeconds(8f);
            IGA.SkillDMG_120 -= RandomStrongNum;
            RanText.text = "0";
            Gob_RanText.SetActive(false);
        }
        else
        {
            RanText.text = "골렘 강화 실패..";
            yield return new WaitForSeconds(3f);
            Gob_RanText.SetActive(false);
        }
        
        
    }
	// Update is called once per frame
	void Update () {
		
	}
}
