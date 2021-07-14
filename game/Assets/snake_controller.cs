using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake_controller : MonoBehaviour
{

    public GameObject snakeHead;

    public Vector2 direction = new Vector2(0,0);

    public float velocity = 3;

    void Start()
    {
        direction = new Vector2(0, 1f);
    }

    void Update()
    {


        if (Input.GetKeyDown("w"))
        {
            direction = new Vector2(0,1f);
        }
        if (Input.GetKeyDown("s"))
        {
            direction = new Vector2(0, -1f);
        }
        if (Input.GetKeyDown("a"))
        {
            direction = new Vector2(-1f, 0);
        }
        if (Input.GetKeyDown("d"))
        {
            direction = new Vector2(1f, 0);
        }

        snakeHead.GetComponent<Rigidbody>().AddForce(new Vector3(direction.x * velocity, 0, direction.y * velocity), ForceMode.VelocityChange);


    }



}