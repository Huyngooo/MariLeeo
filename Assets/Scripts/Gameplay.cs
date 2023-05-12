using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GompaPlay : MonoBehaviour {
    public float speed = 0.2f ;



    private Rigidbody2D myBody;
    // Use this for initialization
    void Start () {
        myBody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        _walk();
    }
    void _walk()
    {

        myBody.velocity = new Vector2(transform.localScale.x, 0) * speed;

    }
    void OnCollisionEnter2D(Collision2D target)
    {

        if (target.gameObject.tag == "reLeft")
        {
            Vector3 temp = transform.localScale;
            temp.x = -4f;
            transform.localScale = temp;
            myBody.velocity = new Vector2(transform.localScale.x, 0) * speed;
        }

        if (target.gameObject.tag == "reRight")
        {
            Vector3 temp = transform.localScale;
            temp.x = 4f;
            transform.localScale = temp;
            myBody.velocity = new Vector2(transform.localScale.x, 0) * speed;
        }
    }
}
