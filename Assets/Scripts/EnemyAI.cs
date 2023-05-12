using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
    public float speed = 2f;

    //private Rigidbody2D myBody;
    //private Animator anim;

	// Use this for initialization
	void Start () {
        //myBody = GetComponent<Rigidbody2D>();
       
	}
	
 

    // Update is called once per frame
    void Update () {
        //_walk();
    }
    void _walk()
    {

        //myBody.velocity = new Vector2(0, transform.localScale.y) * speed;

    }
    //private void OnTriggerEnter2D(Collider2D target)
    //{

    //    if (target.gameObject.tag == "ShootTable")
    //    {
    //        Vector3 temp = transform.localScale;
    //        temp.x = -4f;
    //        transform.localScale = temp;
    //        myBody.velocity = new Vector2(0, transform.localScale.y) * speed;
    //    }
    //}
}
