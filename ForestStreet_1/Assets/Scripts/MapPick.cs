using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapPick : MonoBehaviour
{

    Toggle m_Toggle;
    public Button button;

    void Start()
    {
        m_Toggle = GetComponent<Toggle>();
    }

    public void OnClickToggle()
    {
        if (m_Toggle.isOn == true)
        {
            if (this.tag == "Map1")
            {
                Debug.Log("Map1");
                button.onClick.AddListener(LoadMap1);
            }

            else if (this.tag == "Map2")
            {
                Debug.Log("Map2");
                button.onClick.AddListener(LoadMap2);
            }


            else if (this.tag == "Map3")
            {
                Debug.Log("Map3");
                button.onClick.AddListener(LoadMap3);
            }
        }
    }

    public void LoadMap1()
    {
        SceneManager.LoadScene("Map1");
    }

    public void LoadMap2()
    {
        SceneManager.LoadScene("Map2");
    }

    public void LoadMap3()
    {
        SceneManager.LoadScene("Map3");
    }

}
