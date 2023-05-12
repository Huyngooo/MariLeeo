using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonShoot : MonoBehaviour {
    public GameObject theboom;
    public Transform shootForm;
    public float shotTime;
    float nexShoot = 0f;
    Animator canonAmi;

     void Awake()
    {
        canonAmi = GetComponentInChildren<Animator>();

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player"&& Time.time > nexShoot)
        {
            nexShoot = Time.time + shotTime;
            Instantiate(theboom, shootForm.position, Quaternion.identity);
            canonAmi.SetTrigger("canonShoot");
        }
    }
}
