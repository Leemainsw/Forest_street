using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{

    public static float time; //시간 2초
    public static float scrollSpeed = 1.2f; //스크롤 속도

    private Material BGMaterial; //Quad의 Material 객체선언

    public GameObject Ready; //ready
    public GameObject GameStart; //gamestart

    public GameObject Exit_Canvas;

    public GameObject character1;
    public GameObject character2;
    public GameObject character3;

    public GameObject life;
//타이머
    public Text timeText;
    private float timeTimer = 100.0f;

    void Start()
    {
        
            time = 5.0f; //텀을 두고 배경을 움지임.
            BGMaterial = GetComponent<Renderer>().material;

        if (GoMapPickScenes.a == 1) { character1.SetActive(true); Debug.Log("a =" + GoMapPickScenes.a); }
         else if (GoMapPickScenes.a == 2) { character2.SetActive(true); Debug.Log("a =" + GoMapPickScenes.a); }
         else if (GoMapPickScenes.a == 3) { character3.SetActive(true); Debug.Log("a =" + GoMapPickScenes.a); }

    }

    void Update()
    {
        if (Exit_Canvas.activeSelf != true)
        {
            if (time != 0) //시간계산 10-6
            {
                time -= Time.deltaTime; //6일때 까지 

                if (time > 5.0f && time <= 3.0f) //READY?
                {
                    Ready.SetActive(true);
                    GameStart.SetActive(false);
                }
                else if (time <= 3.0f && time > 1.0f) //START!
                {
                    Ready.SetActive(false);
                    GameStart.SetActive(true);
                }
            }

            if (timeTimer <= 0 && life.activeSelf == true)
            {
                SceneManager.LoadScene("GoodEnding");
            }


            if (Exit_Canvas.activeSelf == true)
                scrollSpeed = 0;

            else
                scrollSpeed = 0.5f;


            if (time <= 0.0f) //time이 0보다 작으면 타이머 기능 / 백그라운드 움직이기 기능 시작
            {
                GameStart.SetActive(false);

                if (timeTimer > 0)
                {
                    timeTimer -= Time.deltaTime;
                    timeText.text = timeTimer.ToString();
                }

                else if (timeTimer <= 0)
                {
                    scrollSpeed = 0;
                }

                Vector2 newOffset = BGMaterial.mainTextureOffset;
                // OffSet 객체 선언
                newOffset.Set(newOffset.x + (scrollSpeed * Time.deltaTime), 0);
                // 현재 x값에 속도를 더함
                BGMaterial.mainTextureOffset = newOffset;
                //최종적으로 오프셋 값 지정
            }

        }
    }
}