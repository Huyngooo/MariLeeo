using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomCtroller : MonoBehaviour {
    public float boomSpeedHight;
    public float boomSpeedLow;
    public float boomAngel;


    Rigidbody2D canonRB;
    void Awake()
    {
        canonRB = GetComponent<Rigidbody2D>();     
    }


    // Use this for initialization
    void Start () {
        canonRB.AddForce(new Vector2(Random.Range(-boomAngel, boomAngel), Random.Range(boomSpeedLow, boomSpeedHight)), ForceMode2D.Impulse);
            
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
