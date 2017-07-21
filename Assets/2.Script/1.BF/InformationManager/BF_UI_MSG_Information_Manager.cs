using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BF_UI_MSG_Information_Manager : MonoBehaviour {

    public GameObject Msg_TextBox;
    public GameObject Msg_TextBalloon;


    //INSTANCE_ UP,BALLOON
    public void Msg_TextBox_MoveUp(string InputMsg)
    {
        StartCoroutine(MSG_MoveUp(InputMsg));
    }
    public void Msg_TextBox_Balloon(string InputMsg)
    {
        StartCoroutine(MSG_Balloon(InputMsg));
    }


    //ONOFF_ NOMOVE 
    public void Msg_TextBox_NoMove_ON(string InputMsg)
    {
        transform.GetChild(0).GetComponent<Text>().text = InputMsg;
    }
    public void MSG_TextBox_NoMove_OFF()
    {
        transform.GetChild(0).GetComponent<Text>().text = "";
    }


    IEnumerator MSG_Balloon(string msg)
    {
        char[] cha = msg.ToCharArray();
        GameObject obj = Instantiate(Msg_TextBalloon, this.transform);
        for(int i =0; i < cha.Length; i++)
        {
            obj.transform.GetChild(0).GetComponent<Text>().text += cha[i].ToString();
            yield return new WaitForSeconds(0.15f);
        }       

        yield return new WaitForSeconds(2.5f);
        Destroy(obj.gameObject);
    }

    IEnumerator MSG_MoveUp(string msg)
    {
        GameObject obj = Instantiate(Msg_TextBox, this.transform);
        obj.GetComponent<Text>().text = msg;
        RectTransform rtfom = obj.GetComponent<RectTransform>();

        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 10f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 9.5f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 9f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 8.5f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 8f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 7.5f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 7f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 6.5f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 6f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 5.5f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);

        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 5f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 4.5f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 4f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 3.5f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 3f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 2.5f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 2f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 1.5f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 1f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);
        rtfom.position = new Vector3(rtfom.position.x, rtfom.position.y + 1f, rtfom.position.z);
        yield return new WaitForSeconds(0.05f);

        Destroy(obj.gameObject);
    }
    
}
