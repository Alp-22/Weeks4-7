using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 50f;
    float damage = 10f;
    int counter;
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        Vector2 objectPos = transform.position;
        transform.position += transform.right * speed * Time.deltaTime;
        counter++;
        if (counter >= 480)
        {
            Destroy(gameObject);
        }
    }
}
