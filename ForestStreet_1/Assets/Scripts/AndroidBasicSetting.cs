using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidBasicSetting : MonoBehaviour
{
    void Start()
    {
        Screen.SetResolution(1908, 1080, true);


    }

    // Update is called once per frame
    void Update() {
        //if (Application.platform == RuntimePlatform.Android)
            if (Input.GetKey("escape"))
                Application.Quit();
    }
}

