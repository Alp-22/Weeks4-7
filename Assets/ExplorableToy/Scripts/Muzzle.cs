using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzzle : MonoBehaviour
{
    // Start is called before the first frame update
    int counter = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter >= 15)
        {
            Destroy(gameObject);
        }
    }
}
