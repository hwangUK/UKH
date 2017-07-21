using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Infor_MapManager : MonoBehaviour {

    public static int MapType;
    public static bool AlreadyCall_01 = false;
    public static bool AlreadyCall_02 = false;

    public RectTransform Cloud_01;
    public RectTransform Cloud_02;

    public Button[] MapButtons;

    
    public GameObject FLAG;
    public GameObject REDBOOM;
    public GameObject WARNING;
    public GameObject ARROWRED;
    public GameObject ARROWBLUE;


    //public GameObject MyWorld;
    
    

    // Use this for initialization

    void Start () {
        GameInformation.SetActive_False_All(Player.MODEL);
        MapButtons = transform.GetChild(0).GetChild(0).GetComponentsInChildren<Button>();
        Map_01_OnOffManager();
        Map_02_OnOffManager();
    }
    

    private void Update()
    {
        Cloud_Move();

        if (PlayerMainEventManager.Invade_Stage_01 == true && AlreadyCall_01 == false)
        {
            Map_01_OnOffManager();
            AlreadyCall_01 = true;
        }
                    
        if (PlayerMainEventManager.Invade_Stage_02 == true && AlreadyCall_02 == false)
        {
            Map_02_OnOffManager();
            AlreadyCall_02 = true;
        }        
    }

    public void SetMapStageNumber(int Input)
    {
        MapType = Input;
    }

    private void Cloud_Move()
    {
        Cloud_01.Translate(Vector3.right * 0.6f * Time.deltaTime);
        Cloud_02.Translate(Vector3.right * 0.7f * Time.deltaTime);
        if (Cloud_01.anchoredPosition.x >= 2000f)
        {
            Cloud_01.anchoredPosition = new Vector2(Random.Range(-1500f, -1300f), Random.Range(-1000f, 700f));
        }
        if (Cloud_02.anchoredPosition.x >= 900f)
        {
            Cloud_02.anchoredPosition = new Vector2(Random.Range(-2200f, -2000f), Random.Range(-1000f, 700f));
        }
    }
    
    public void Map_01_OnOffManager()
    {        
        // 1_STAGE========================================================
        if (Player.NewPlayer.STAGE_01 == 1) //점령 했을시@@@@
        {
            MapButtons[0].transform.GetChild(1).gameObject.SetActive(true);//점령지역 1탄 점령맵 켜기 MYMYMY
            //MyWorld.transform.GetChild(0).gameObject.SetActive(true);
            MapButtons[0].interactable = false; //기본맵 1탄 끄기
            MapButtons[0].gameObject.transform.GetChild(0).gameObject.SetActive(false);                       
                        
            MapButtons[1].interactable = true; //공격가능지역 2탄      
            MapButtons[1].gameObject.transform.GetChild(0).gameObject.SetActive(true);

            //Instantiate(FLAG, transform.GetChild(1).GetChild(1).transform);  // 1스테이지 점령깃발생성

            if (PlayerMainEventManager.Invade_Stage_01 == true ) // 적이 공격해왔다
            {
                Instantiate(REDBOOM, transform.GetChild(1).GetChild(1).transform);
                Instantiate(WARNING, transform.GetChild(1).GetChild(1).transform);

                MapButtons[0].interactable = true;                   //점령지역 MYWOLD지워주기 1탄 점령맵 켜기 
                MapButtons[0].transform.GetChild(1).gameObject.SetActive(false);
                //MapButtons[0].gameObject.transform.GetChild(0).gameObject.SetActive(true);
                //MyWorld.transform.GetChild(0).gameObject.SetActive(false); // 
            }

            else if (PlayerMainEventManager.Invade_Stage_01 == false && PlayerMainEventManager.DelBoom_01 == true) // 공격 효과제거 초기에한번은 처리하면 안됨 이벤트 발생시 레드붐 삭제 반영 
            {                
                Destroy(transform.GetChild(1).GetChild(1).GetChild(1).gameObject);                
                Destroy(transform.GetChild(1).GetChild(1).GetChild(2).gameObject);
                PlayerMainEventManager.DelBoom_01 = false;
            }            

        }

        if (Player.NewPlayer.STAGE_01 == 0) //미점령 혹은 빼앗겻을 시@@@@
        {
            MapButtons[0].interactable = true; //공격가능지역 여기뿐 1탄
            MapButtons[0].gameObject.transform.GetChild(0).gameObject.SetActive(true);

            MapButtons[1].interactable = false;
            MapButtons[1].gameObject.transform.GetChild(0).gameObject.SetActive(false);

            MapButtons[0].transform.GetChild(1).gameObject.SetActive(false); //마이맵 끄기
            //MyWorld.transform.GetChild(0).gameObject.SetActive(false);

            if (transform.GetChild(1).GetChild(1).childCount != 0)
            {
                Destroy(transform.GetChild(1).GetChild(1).GetChild(0).gameObject); //깃발있으면지워주기
            }
            if (transform.GetChild(1).GetChild(2).childCount != 0)
            {
                Destroy(transform.GetChild(1).GetChild(2).GetChild(0).gameObject); //다음탄 화살표있으면지워주기
            }
        }
                
    }

    public void Map_02_OnOffManager()
    {
        if (Player.NewPlayer.STAGE_02 == 1)
        {
            //Instantiate(FLAG, transform.GetChild(1).GetChild(2).transform);  // 2스테이지 점령깃발생성   
            //instantiate(ARROWRED, transform.GetChild(1).GetChild(3).transform); //공격가능지역 화살표아이콘

            //MyWorld.transform.GetChild(1).gameObject.SetActive(true);//점령지역 2탄 점령맵 켜기
            MapButtons[1].transform.GetChild(1).gameObject.SetActive(true);
            MapButtons[1].interactable = false;
            MapButtons[1].gameObject.transform.GetChild(0).gameObject.SetActive(false);

            MapButtons[2].interactable = true; //공격가능지역 3탄
            MapButtons[2].gameObject.transform.GetChild(0).gameObject.SetActive(true);


            if (PlayerMainEventManager.Invade_Stage_02 == true) // 적이 공격해왔다
            {
                Instantiate(REDBOOM, transform.GetChild(1).GetChild(2).transform);
                Instantiate(WARNING, transform.GetChild(1).GetChild(2).transform);

                MapButtons[1].interactable = true;
                //MapButtons[2].gameObject.transform.GetChild(0).gameObject.SetActive(true);

                MapButtons[1].transform.GetChild(1).gameObject.SetActive(false);
                //MyWorld.transform.GetChild(1).gameObject.SetActive(false);
            }
            else if (PlayerMainEventManager.Invade_Stage_02 == false && PlayerMainEventManager.DelBoom_02 == true)
            {
                Destroy(transform.GetChild(1).GetChild(2).GetChild(1).gameObject);
                Destroy(transform.GetChild(1).GetChild(2).GetChild(2).gameObject);
                PlayerMainEventManager.DelBoom_02 = false;
            }
        }

        if (Player.NewPlayer.STAGE_02 == 0 && Player.NewPlayer.STAGE_01 == 1)
        {
            MapButtons[1].interactable = true; //공격가능 오직 2탄
            MapButtons[1].gameObject.transform.GetChild(0).gameObject.SetActive(true);

            MapButtons[1].transform.GetChild(1).gameObject.SetActive(false);
            //MyWorld.transform.GetChild(1).gameObject.SetActive(false);//마이맵 끄기

            MapButtons[2].interactable = false;
            MapButtons[2].gameObject.transform.GetChild(0).gameObject.SetActive(false);

            if (transform.GetChild(1).GetChild(2).childCount != 0)
            {
                Destroy(transform.GetChild(1).GetChild(2).GetChild(0).gameObject); //깃발있으면지워주기
            }

            if (transform.GetChild(1).GetChild(3).childCount != 0)
            {
                Destroy(transform.GetChild(1).GetChild(3).GetChild(0).gameObject); //다음탄 화살표있으면지워주기
            }

        }
    }
}
