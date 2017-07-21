using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_DF_112 : MonoBehaviour {    

    public GameObject Bullet;
    
    public float DieTime = 4f;
    public float DelayTime = 0.4f;
    IG_MainAI AI;
    IG_MainPlayer P;

    
    void Start()
    {
        AI = GameObject.FindGameObjectWithTag("Mon").GetComponent<IG_MainAI>();
        P = GameObject.FindGameObjectWithTag("Cha").GetComponent<IG_MainPlayer>();
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Cha" && Player.NewPlayer.IsATKDEF_12 == 1) //감지
        {
            Debug.Log("FINDCHA!");
            transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].SetColor("_EmissionColor", Color.red);
            StartCoroutine(MakeAndShoot());
            StartCoroutine(Colider_OnOff());
        }
        else if(other.gameObject.tag == "Mon" && Player.NewPlayer.IsATKDEF_12 == 2) //감지
        {
            Debug.Log("FINDMON!");
            transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].SetColor("_EmissionColor", Color.red);
            
            StartCoroutine(MakeAndShoot());
            StartCoroutine(Colider_OnOff());            
        }
        else
        {
            transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].SetColor("_EmissionColor", Color.yellow);
        }
            
    }

    IEnumerator Colider_OnOff()
    {
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Collider>().enabled = true;
    }

    IEnumerator MakeAndShoot()
    {
        GameObject obj = Instantiate(Bullet, transform.position + new Vector3(0f, 5f, 0f), Quaternion.identity);
        obj.transform.Rotate(0f, Random.Range(0f, 360f), 0f, Space.Self);
        yield return new WaitForSeconds(DieTime);
        Destroy(obj.gameObject);
    }

   
}
