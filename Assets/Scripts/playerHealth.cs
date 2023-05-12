using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {
    public float maxHealth;
    float curentHealth;
    public GameObject bloodEffect;

    public static playerHealth instance;
    // Use this for initialization
   
   
    void Start () {
        curentHealth = maxHealth;
        playerHealthSlider.maxValue = maxHealth;
        playerHealthSlider.value = maxHealth;
	}
    // khai báo các biến UI
    public Slider playerHealthSlider;
	// Update is called once per frame
	void Update () {
		
	}
    public void addDamage(float damage)
    {
        if (damage <= 0)
            return ;
        curentHealth -= damage;

        playerHealthSlider.value = curentHealth;

        if (curentHealth <= 0)
            makeDate();
    }
    //  tạo ra chức năng hồi máu khi ăn viên máu
    public void addhealth (float healthAmount)
    {
        curentHealth += healthAmount;
        if (curentHealth > maxHealth)
            curentHealth = maxHealth;
        playerHealthSlider.value = curentHealth;
    }
    void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void makeDate()
    {
        Instantiate(bloodEffect, transform.position, transform.rotation);
        gameObject.SetActive(false);
        GamePause.instance.CharterDiedShowPanal();
    }
}
