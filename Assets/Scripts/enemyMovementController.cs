using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovementController : MonoBehaviour
{
    public float enemySpeed;
    Rigidbody2D enemyRB;
    Animator enemyAmi;
    // khai báo biến để enemy có thể quay mặt sang nhân vật!
    public GameObject enemyGraphic;
    bool facingRinght = true;
    float facingTime = 5f;
    float nextFlip = 0f;
    bool canFlip = true;
    // Use this for initialization

    private void Awake()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        enemyAmi = GetComponentInChildren<Animator>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFlip)
        {
            nextFlip = Time.time + facingTime; //thời gian hiện tại mà lớn hơn 5s thì có thể quay dc nhân vật
            flip();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (facingRinght && other.transform.position.x < transform.position.x)
            {
                flip();
            }
            else if (!facingRinght && other.transform.position.x > transform.position.x)
            {
                flip();
            }
            canFlip = false;
        }
    }
    void OnTriggerStay2D(Collider2D other)// khi va chạm vào trong nhân vật sẽ đuổi theo
    {
        if (other.tag == "Player")
        {
            if (!facingRinght)

                enemyRB.AddForce(new Vector2(-1, 0) * enemySpeed);
            else enemyRB.AddForce(new Vector2(1, 0) * enemySpeed);
            enemyAmi.SetBool("Run", true);
          
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canFlip = true;
            enemyRB.velocity = new Vector2(0, 0);
            enemyAmi.SetBool("Run", false);
        }
    }
    void flip()
    {
        if (!canFlip) //<=> canFlip = false;
            return;
        facingRinght = !facingRinght;
        Vector3 theCalse = enemyGraphic.transform.localScale;
        theCalse.x *= -1;
        enemyGraphic.transform.localScale = theCalse;
    }
}
