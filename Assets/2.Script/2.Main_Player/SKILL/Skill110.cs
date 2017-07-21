using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill110 : MonoBehaviour {

    public int HP = 100;

    public int reduceAmt_BAtk = 1;

    public GameObject Marin;

    

    // Use this for initialization
    void Start () {

        Skill_110();
    }
	
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Mon_Atk")
        {
            HP -= reduceAmt_BAtk;
        }
    }

    void Skill_110()
    {
        if(Player.NewPlayer.IsATKDEF_12 == 1)
        {
            
        }

        if(Player.NewPlayer.IsATKDEF_12 == 2)
        {
            StartCoroutine(DEF_Skill_110());
        }
    }

    IEnumerator DEF_Skill_110()
    {
        while (gameObject)
        {
            yield return new WaitForSeconds(3f);
            Instantiate(Marin, transform.position, Quaternion.identity);
        }
        
    }
}
