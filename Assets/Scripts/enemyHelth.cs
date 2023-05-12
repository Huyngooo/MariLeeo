using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHelth : MonoBehaviour {
    public float maxHealth;
    float curenhealth;
    // Use this for initialization

    // biến để tạo hiệu ứng khi enemy die
    public GameObject enemyHealththEF;

    //khai báo biến để tạo thanh máu
    public Slider enemyHealthSlider;

    //khai báo các biến để khi enemy chết sẽ rơi ra viên máu
    public bool drop;
    public GameObject theDrop; // muốn rơi ra cái gì thì kéo vào đây
	void Start () {
        curenhealth = maxHealth;

        enemyHealthSlider.maxValue = maxHealth;
        enemyHealthSlider.value = maxHealth;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void addDamge(float damage)
    {
        enemyHealthSlider.gameObject.SetActive(true);// khi nhhận viên đạn mới hiện máu

        curenhealth -= damage;

        enemyHealthSlider.value = curenhealth;

        if (curenhealth <= 0)
            makeDead();
    }
    void makeDead()
    {
        gameObject.SetActive(false);
        Instantiate(enemyHealththEF, transform.position, transform.rotation);
        //chức năng rơi ra viên máu
        if (drop)
        {
            Instantiate(theDrop, transform.position, transform.rotation);
        }
    } 
}
