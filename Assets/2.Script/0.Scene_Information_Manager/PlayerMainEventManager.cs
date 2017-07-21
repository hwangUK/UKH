using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMainEventManager : MonoBehaviour {

    public static bool Invade_Stage_01 = false;
    public static bool Invade_Stage_02 = false;
    public static bool Invade_Stage_03 = false;

    public static bool DelBoom_01 = false;
    public static bool DelBoom_02 = false;

    public int MAX_INVADE_RANGE;
    private void Start()
    {
        GameObject.Find("SelectRobbyManager").transform.GetChild(1).GetChild(1).gameObject.SetActive(false);
        StartCoroutine(CheckInvade());                
    }



    IEnumerator CheckInvade()
    {
        while (true)
        {
            int r = Random.Range(0, MAX_INVADE_RANGE);
            yield return new WaitForSeconds(1f);
            if (r == 1 && Invade_Stage_01 == false )
            {
                if (Player.NewPlayer.STAGE_01 == 1)
                {
                    StartCoroutine(GameInformation.SYS_MSG("점령중인 1번 지역에 적이 쳐들어왔습니다 방어를 준비해야 합니다", 50f));                    
                    Invade_Stage_01 = true;
                    Debug.Log("점령중인 1번 지역에 적이 쳐들어왔습니다 방어를 준비해야 합니다");
                }                
            }

            if (r == 2 && Invade_Stage_02 == false)
            {                
                if (Player.NewPlayer.STAGE_02 == 1)
                {
                    StartCoroutine(GameInformation.SYS_MSG("점령중인 2번 지역에 적이 쳐들어왔습니다 방어를 준비해야 합니다", 50f));                   
                    Invade_Stage_02 = true;
                    Debug.Log("점령중인 2번 지역에 적이 쳐들어왔습니다 방어를 준비해야 합니다");
                }                
            }

            if (r == 3 && Invade_Stage_03 == false)
            {
                if (Player.NewPlayer.STAGE_03 == 1 )
                {
                    StartCoroutine(GameInformation.SYS_MSG("점령중인 3번 지역에 적이 쳐들어왔습니다 방어를 준비해야 합니다", 50f));                   
                    Invade_Stage_03 = true;
                    Debug.Log("점령중인 3번 지역에 적이 쳐들어왔습니다 방어를 준비해야 합니다");
                }
            }
            
        }
        
    }
}
