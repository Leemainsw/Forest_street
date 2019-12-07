using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("Began : " + touch.position);
            }

            if (touch.phase == TouchPhase.Ended)
            {
                Debug.Log("Ended : " + touch.position);
                SceneManager.LoadScene("Lobby");
            }
        }
    }
}

