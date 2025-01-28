using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class ClockRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = -200f;
    public AudioSource audioSource;
    public AudioClip clip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float counter = transform.localEulerAngles.z;
        //print(counter);
        //Vector3 clockHand = transform.eulerAngles;
        Vector3 clockPos = transform.position;
        //clockHand += new Vector3(0, 0, 2);
        //float direction = 2f;
        transform.Rotate(0, 0, speed * Time.deltaTime);
        transform.position = clockPos;
        //transform.eulerAngles = clockHand;
        if (counter % 30 <= 0.01)
        {
            if (audioSource.isPlaying == false)
            {
                //audioSource.Play();
                audioSource.PlayOneShot(clip);
            }
        }
    }
}
