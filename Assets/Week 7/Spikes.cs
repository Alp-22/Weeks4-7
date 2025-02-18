using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    // Start is called before the first frame update
    //Initialize variables
    public SpriteRenderer sprite;
    //Animation curve variable
    [SerializeField]
    public AnimationCurve hitReg;
    //Variable for the bullet spawner game object
    Color changeColor = new Color(0, 0, 0, 255);
    float colorCurve;
    bool hit;
    int counter;
    public GameObject player;
    //Health variables
    float dummyHP = 1000f, dummyMaxHP = 1000f;
    //int respawnCounter = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
                //Initiaize dummy position and bullet position
                Vector3 playerPos = player.transform.position;
                Vector3 spikePos = transform.position;
                if (playerPos.x <= spikePos.x + 0.8f &&
                    playerPos.x >= spikePos.x - 0.8f &&
                    playerPos.y <= spikePos.y + 0.8f &&
                    playerPos.y >= spikePos.y - 0.8f)
                {
                    Debug.Log("Hit");
                    //Enable hit boolean
                    hit = true;
                    //Sets the colors to default
                    colorCurve = 0f;
                    changeColor = Color.red;
                    counter = 0;
                    sprite.color = new Color(255, 255, 255);
                    //Debug.Log(dummyHP);
                }
           
        
        Color color = new Color(0, 0, 0, 255);
        if (hit && counter <= 255)
        {
            //If hit fade from red to white
            colorCurve = color.r + Time.deltaTime;
            changeColor.b += hitReg.Evaluate(colorCurve);
            changeColor.g += hitReg.Evaluate(colorCurve);
            sprite.color = changeColor;
            counter++;
        }
        else
        {
            //Sets everything to default when the timer ends
            colorCurve = 0f;
            changeColor = Color.red;
            counter = 0;
            hit = false;
            sprite.color = new Color(255, 255, 255);
        }
    }
}
        