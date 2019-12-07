using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_No : MonoBehaviour
{
    public Component Exit_Canvas;
    public void OnClickExit_No()
    {
        Exit_Canvas.gameObject.SetActive(false);
    }
}
