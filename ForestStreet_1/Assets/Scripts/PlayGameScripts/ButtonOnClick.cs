using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonOnClick : MonoBehaviour
{


    private void Start()
    {

    }
    public void LeftDown()
    {
        Debug.Log("LeftDown");
        Player.inputLeft = true;
    }

    public void LeftUp()
    {
        Debug.Log("LeftUp");
        Player.inputLeft = false;
    }

    public void RightDown()
    {
        Debug.Log("RightDown");
        Player.inputRight = true;
    }

    public void RightUp()
    {
        Debug.Log("RightUp");
        Player.inputRight = false;
    }

}
