using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hunter : MonoBehaviour
{

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        if (life3.activeSelf == false && life2.activeSelf == false && life1.activeSelf == false)
        {
            SceneManager.LoadScene("BadEnding");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Vector2 swap = this.transform.position;

        if (other.tag == "Wolf" || other.tag == "Tiger" || other.tag == "Bear")
        {
            if (life3.activeSelf == true) { life3.SetActive(false); swap.x = 317f; this.transform.position = swap; }
            else if (life2.activeSelf == true) { life2.SetActive(false); swap.x = 317f; this.transform.position = swap; }

            else if (life1.activeSelf == true) {
                life1.SetActive(false); swap.x = 317f; this.transform.position = swap;
            }
        }
    }
}
