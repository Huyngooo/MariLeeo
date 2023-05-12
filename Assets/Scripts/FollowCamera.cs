using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public Transform target;
    public Transform leftBounds;
    public Transform rightBrounds;


    public float smoothDampTime = 0.15f;

    private Vector3 smoothDampVelocity = Vector3.zero;

    private float camWith, camHeight, levelMinX, levelMaxX;


    //Use this for initialization

    void Start()
    {

        camHeight = Camera.main.orthographicSize * 2;
        camWith = camHeight * Camera.main.aspect;

        float leftBoundWidth = leftBounds.GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2;
        float righttBoundWidth = rightBrounds.GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2;


        levelMinX = leftBounds.position.x + leftBoundWidth + (camWith / 2);
        levelMaxX = rightBrounds.position.x - leftBoundWidth - (camWith / 2);

    }

    //Update is called once per frame

    void Update()
    {
        if (target)
        {
            float targetX = Mathf.Max(levelMinX, Mathf.Min(levelMaxX, target.position.x));

            float x = Mathf.SmoothDamp(transform.position.x, targetX, ref smoothDampVelocity.x, smoothDampTime);
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }

    }
}
