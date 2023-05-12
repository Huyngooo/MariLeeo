using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControll : MonoBehaviour
{
    public bool drop;
    public GameObject theDrop;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameObject.SetActive(false);
            Instantiate(theDrop, new Vector2( transform.position.x,transform.position.y+3) ,transform.rotation);
            //lam roi ra item
            if (drop)
            {

                Instantiate(theDrop, new Vector2(transform.position.x, transform.position.y+3), transform.rotation);

            }
        }
    }
}
