using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeytroyMe : MonoBehaviour {

    // Use this for initialization
    public float DestroyMe;
	void Start () {
        Destroy(gameObject, DestroyMe);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
