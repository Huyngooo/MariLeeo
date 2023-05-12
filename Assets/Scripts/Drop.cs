using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {
    public bool drop;
    public GameObject theDrop;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameObject.SetActive(true);
            Instantiate(theDrop, transform.position, transform.rotation);
            //lam roi ra item
            if (drop)
            {

                Instantiate(theDrop,transform.position, transform.rotation);

            }
        }   
    }
}
