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
        if (Input.GetKey(KeyCode.W))
        {
            playerPos.y += speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerPos.x -= speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerPos.y -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerPos.x += speed;
        }
        transform.position = playerPos;
    }
}
