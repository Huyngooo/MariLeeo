using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed;
    public float jumHeight;



    Rigidbody2D myBody;
    Animator myAnim;


    bool facingRight;
    // Use this for initialization
    bool grounded;
    // khai báo các biến để bắn
    public Transform gunTip; //ví trí bắn
    public GameObject bullet;
    float firerate = 0.5f; // trong vòng 0,5 giây bắn 1 lần
    float nextfire = 0; //có thể bắn ngay lập tức
    void Start()
    {
        myAnim = GetComponent<Animator>();
        myBody = GetComponent<Rigidbody2D>();

        facingRight = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");

        myAnim.SetFloat("speed", Mathf.Abs(move));
        myAnim.SetFloat("jump", Mathf.Abs(jump));

        myBody.velocity = new Vector2(move * maxSpeed, myBody.velocity.y);
        if (move > 0 && !facingRight)
        {
            flip();
        }
        else if (move < 0 && facingRight)
        {
            flip();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                grounded = false;
                myBody.velocity = new Vector2(myBody.velocity.x, jumHeight);
            }

            //GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumpHeight, 0);

        }

        //chức nắng bắn từ bán phím
        if (Input.GetAxisRaw("Fire1") > 0)
            fireBullet();
    }
    void flip()
    {
        facingRight = !facingRight;
        Vector3 theSacle = transform.localScale;
        theSacle.x *= -1;
        transform.localScale = theSacle;

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            grounded = true;

        }


    }


    public void Uplayer(float force)
    {
        if (grounded)
        {
            grounded = false;
            myBody.AddForce(new Vector2(0, force));
        }
    }

    // chức năng bắn
    void fireBullet()
    {
        if (Time.time > nextfire) //nếu như lớn hơn time hiện tại thì cho bắn
        {
            nextfire = Time.time + firerate; // cứ sau 0,5 giây mới dc bắn
            if (facingRight)
            {
                Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            else if (!facingRight)
            {
                Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 180)));
            }
        }
    }
}
