using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GoMapPickScenes : MonoBehaviour
{

    public Toggle character1;
    public Toggle character2;
    public Toggle character3;

    public static int a = 0;

    public void OnClickGoMapPickScenes()
    {

        if (!(character1.isOn != true && character2.isOn != true && character3.isOn != true))
        {
            if (character1.isOn == true) { a = 1; Debug.Log(a); }
            else if (character2.isOn == true) { a = 2; Debug.Log(a); }
            else if (character3.isOn == true) { a = 3; Debug.Log(a); }

            Debug.Log("OnClickGoMapPickScenes");
            SceneManager.LoadScene("MapPick");
        }

        else a = 0;

    }
}
