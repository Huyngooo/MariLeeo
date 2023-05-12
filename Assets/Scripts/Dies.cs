using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dies : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0f;
            //GamePause.instance.CharterDiedShowPanal();
            playerHealth.instance.makeDate();



        }
    }
}
