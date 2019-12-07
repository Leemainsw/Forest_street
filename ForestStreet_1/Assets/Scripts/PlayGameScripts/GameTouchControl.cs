using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTouchControl : MonoBehaviour
{
    int YellowTouchCount;

    public GameObject Fail;

    void Start()
    { 
        Fail.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other) {

        Debug.Log("첫 OnTriggerEnter2D");

        if (Input.touchCount > 0)
        {
            Debug.Log("OnTriggerEnter2D");

            Touch touch = Input.GetTouch(0);
            Vector2 Touchpos = touch.position;

            if (other.tag == "Red")
            {
                if (Touchpos.x <= Screen.width / 2) // 왼쪽 -> 레드 -> 성공
                {
                    Fail.SetActive(false);
                    Debug.Log("Red 클릭 성공");                               
                }

                else if (Touchpos.x >= Screen.width / 2) //오른쪽 -> 블루 -> 실패
                {                
                    Fail.SetActive(true);
                    //Fail.SetActive(false);
                    //GameObject.Find("BackGround").GetComponent<BackGroundScroll>().scrollSpeed = 0; //목숨
                    Debug.Log("Red 클릭 실패");
                }
            }

            else if (other.tag == "Blue")
            {
                if (Touchpos.x <= Screen.width / 2) // 왼쪽 -> 레드 -> 실패
                {
                    Fail.SetActive(true);
                   //Fail.SetActive(false);
                    Debug.Log("Blue 클릭 실패");
                    //GameObject.Find("BackGround").GetComponent<BackGroundScroll>().scrollSpeed = 0;  //목숨
                }

                else if (Touchpos.x >= Screen.width / 2) //오른쪽 -> 블루 -> 성공
                {
                    Fail.SetActive(false);
                    Debug.Log("Blue 클릭 성공");
                }
            } //else if "Blue" 일 때 터치 확인 닫기  

            else if (other.tag == "Yellow")
            {
                if (touch.phase== TouchPhase.Began)
                    YellowTouchCount ++;
                Debug.Log(YellowTouchCount);
            } //else if "Blue" 일 때 터치 확인 닫기  

        }

        else if (Input.touchCount < 0)
        {
            Fail.SetActive(true);
            Debug.Log("터치없음");
        }

    } //OnTriggerEnter2D 닫기

}
