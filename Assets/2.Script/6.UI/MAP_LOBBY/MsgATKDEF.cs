using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MsgATKDEF : MonoBehaviour {

    
    public void ClickAtkDef()
    {
        StartCoroutine(clickATKDEF());
    }

    IEnumerator clickATKDEF()
    {
        StartCoroutine( GameObject.Find("SelectRobbyManager").transform.GetChild(0).GetChild(1).GetComponent<Alpha>().Alpha_FadeOut());
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(Infor_MapManager.MapType + 4);
    }
}
