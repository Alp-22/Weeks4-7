using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class ClockRotNoSound : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = -200f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 clockHand = transform.eulerAngles;
        Vector3 clockPos = transform.position;
        //clockHand += new Vector3(0, 0, 2);
        //float direction = 2f;
        transform.Rotate(0, 0, speed * Time.deltaTime);
        transform.position = clockPos;
        //transform.eulerAngles = clockHand;
    }
}
