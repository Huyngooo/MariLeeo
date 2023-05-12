using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up : MonoBehaviour {
    public float fore = 500f;
    private Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();

    }
    // Use this for initialization
    void Start() {

    }
    IEnumerator AnimateBouncy()
    {
        anim.Play("Up");
        yield return new WaitForSeconds(.5f);
        anim.Play("Down");
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerController>().Uplayer(fore);
            StartCoroutine(AnimateBouncy());
        }
    }
    // Update is called once per frame
    void Update() {

        }
    }
