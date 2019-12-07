using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public Component Exit_Canvas;
    void Start()
    {
        Exit_Canvas.gameObject.SetActive(false);
    }
    public void OnclickButton()
    {
        Exit_Canvas.gameObject.SetActive(true);
    }

}
