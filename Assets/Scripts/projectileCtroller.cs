using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileCtroller : MonoBehaviour {
    public float bulletSpeed;
    Rigidbody2D myBody;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        if (transform.localRotation.z > 0) //nếu vị trí của viên đạn đang quay mà có vị trí theo trục Z lớn hơn 0 đang quay bên trai thì cho n quay sang bên trái
        {
            myBody.AddForce(new Vector2(-1, 0) * bulletSpeed, ForceMode2D.Impulse);
        }else myBody.AddForce(new Vector2(1, 0) * bulletSpeed, ForceMode2D.Impulse);
    }
        // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //tạo chức nắng làm viên đạn dừng lại
    public void removeFore()
    {
        myBody.velocity = new Vector2(0, 0);
    }   
}
