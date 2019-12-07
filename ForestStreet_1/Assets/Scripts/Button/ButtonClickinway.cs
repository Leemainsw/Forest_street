using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickinway : MonoBehaviour
{

    public GameObject information;
    public GameObject GameWay;
    int a = 1;
    int b = 1;

    public void InformationOnclick()
    {
        information.SetActive(true);
        a++;

        if(a%2==0)
        information.SetActive(false);
    }

    public void GameWayOnClick()
    {
        GameWay.SetActive(true);
        b++;

        if (b % 2 == 0)
        GameWay.SetActive(false);
    }
}
