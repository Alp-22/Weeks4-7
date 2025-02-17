using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Adjust player speed
        float speed = 0.005f;
        Vector2 playerPos = transform.position;
        //If W is pressed move the player up
        if (Input.GetKey(KeyCode.W))
        {
            playerPos.y += speed;
        }
        //If A is pressed move the player left
        if (Input.GetKey(KeyCode.A))
        {
            playerPos.x -= speed;
        }
        //If S is pressed move the player down
        if (Input.GetKey(KeyCode.S))
        {
            playerPos.y -= speed;
        }
        //If D is pressed move the player right
        if (Input.GetKey(KeyCode.D))
        {
            playerPos.x += speed;
        }
        transform.position = playerPos;
    }
}
