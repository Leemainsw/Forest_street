using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 빨강 = 왼쪽 toggle 터치
    // 파랑 = 오른쪽 toggle 터치
    // 노랑 = 터치 개수 체크 -> 점수 

    public GameObject thisPlayer;
    public GameObject hunter;

    int YellowTouchCount; //yellow의 터치 개수 체크 

    public GameObject Fail;


    //public Toggle left; //왼쪽 토글
    //public Toggle right; //오른쪽 토글

    //public Button Left;
    //public Button Right;

    public static bool inputLeft;
    public static bool inputRight;
    
    void Start()
    {
        Fail.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other) //충돌이 일어났을 때
    {

        Vector2 swap = hunter.transform.position;

        Debug.Log("In OnTriggerEnter2D"); //충돌확인

            if (other.tag == "Red") //충돌한 물체가 red블럭일 때
            {
                Debug.Log("Red 블럭 충돌"); //충돌확인

                if (inputLeft==true&&inputRight!=true) {               
                        swap.x -= 10f;

                    hunter.transform.position = swap;
                    Debug.Log("Red 블럭 통과!");
                    Fail.SetActive(false);
                }

                else {
                if (swap.x != -54f)
                    swap.x += 10f;

                    hunter.transform.position = swap;
                    Debug.Log("Red 블럭 실패!");
                    Fail.SetActive(true);
           
                }
            }

            else if (other.tag == "Blue") //충돌한 물체가 blue블럭일 때
            {
                Debug.Log("Blue 블럭 충돌"); //충돌확인
 
                if (inputRight==true&&inputLeft!=true)
                {
                    swap.x -= 10f;
                    hunter.transform.position = swap;

                    Debug.Log("Blue 블럭 통과!");
                    Fail.SetActive(false);
                }

                else
                {
                    if (swap.x != -54f)
                    swap.x += 10f;
                    hunter.transform.position = swap;

                    Debug.Log("Blue 블럭 실패!");
                    Fail.SetActive(true);
        
                }
            } 

            else if (other.tag == "Yellow") //충돌한 물체가 yellow블럭일 때
            {
                Debug.Log("Yellow 블럭 충돌"); //충돌확인             

                if (inputLeft == true && inputRight == true)
                {
                    Fail.SetActive(false);
                }
                else
                    Fail.SetActive(true);
            }  

    } //OnTriggerEnter2D 닫기

}
