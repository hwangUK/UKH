using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_DF_112_Bullet : MonoBehaviour {
    private void Start()
    {
        StartCoroutine(Del());
    }
    void Update () {        
     transform.Translate(Vector3.forward * Time.deltaTime * 15f);
    }

    IEnumerator Del()
    {
        yield return new WaitForSeconds(6f);
        Destroy(this.gameObject);
    }
}
