using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.005f;
        Vector2 playerPos = transform.position;
        Vector3 playerRot = transform.eulerAngles;
        if (Input.GetKey(KeyCode.A))
        {
            playerPos.x -= speed;
            playerRot.y = 180;
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerPos.x += speed;
            playerRot.y = 0;
        }
        transform.position = playerPos;
        transform.eulerAngles = playerRot;
    }
}
