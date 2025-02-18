using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reaction : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefab;
    public GameObject image;
    public Sprite sprite;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= prefab.transform.position.x+2f && 
            transform.position.x >= prefab.transform.position.x-2f && 
            transform.position.y <= prefab.transform.position.y + 2f && 
            transform.position.y >= prefab.transform.position.y - 2f)
        {
            image.GetComponent<Image>().enabled = true;
            image.GetComponent<Image>().sprite = sprite;
        }
        else
        {
            image.GetComponent<Image>().enabled = false;
        }
    }
}
