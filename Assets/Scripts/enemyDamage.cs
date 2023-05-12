using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour {
    // gây sát thương cho nhân vật
    // Use this for initialization
    public float damege;
    float damerate = 0.5f; // sau time 05s gay sat thuong

    public float pushBackFore; //khi bi gay sat thuong nhan vat nhay len
    float nextDamage; // gay sat thuong nay lap tuc
	void Start () {
        nextDamage = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player" && nextDamage < Time.time) // khi player 
        {
            playerHealth thePlayerHealth = other.gameObject.GetComponent<playerHealth>();
            thePlayerHealth.addDamage(damege);
            nextDamage = damerate + Time.time;

            pushBack(other.transform);
        }

       
        
    }
    void pushBack(Transform pushObject )
    {
        Vector2 pushDrirection = new Vector2(0,(pushObject.position.y - transform.position.y)).normalized; // vi tri cua nhan vat tru di vi tri cua enemy va .normalized la tra ngay vecter co gia tri =1 tra ve gia tri veter binh thuong
        pushDrirection *= pushBackFore;
        Rigidbody2D pushRB = pushObject.gameObject.GetComponent<Rigidbody2D>();
        pushRB.velocity = Vector2.zero;
        pushRB.AddForce(pushDrirection, ForceMode2D.Impulse);// forceMode lap tuc cho n 1 cai luc 
    }
}
