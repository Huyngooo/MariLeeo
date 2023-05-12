using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHit : MonoBehaviour
{
    public float weaponDamage;
    projectileCtroller myPC;
    public GameObject bulletExpolosion;
    void Awake()
    {
        myPC = GetComponentInParent<projectileCtroller>();
    }   // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ShootTable")
        {
            myPC.removeFore();
            //tao hieu ung no
            Instantiate(bulletExpolosion, transform.position, transform.rotation);
            Destroy(gameObject);
            if (other.gameObject.layer == LayerMask.NameToLayer("enemy"))
            {
                enemyHelth hurtEnemy = other.gameObject.GetComponent<enemyHelth>();
                hurtEnemy.addDamge(weaponDamage);
            }
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "ShootTable")
        {
            myPC.removeFore();
            //tao hieu ung no
            Instantiate(bulletExpolosion, transform.position, transform.rotation);
            Destroy(gameObject);
            if (other.gameObject.layer == LayerMask.NameToLayer("enemy"))
            {
                enemyHelth hurtEnemy = other.gameObject.GetComponent<enemyHelth>();
                hurtEnemy.addDamge(weaponDamage);
            }
        }
    }
}