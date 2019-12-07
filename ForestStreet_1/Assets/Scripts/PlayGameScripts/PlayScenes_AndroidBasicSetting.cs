using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScenes_AndroidBasicSetting : MonoBehaviour
{
    public Component Exit_Canvas;
    void Start()
    {
        Screen.SetResolution(Screen.width, Screen.width * 1080 / 1920, true);
        Exit_Canvas.gameObject.SetActive(false);
    }
    public void OnclickButton()
    {
        Exit_Canvas.gameObject.SetActive(true);
    }
    void Update()
    {
        if (Input.GetKey("escape"))
            OnclickButton();
    }
  
}
