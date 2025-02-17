using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSprite : MonoBehaviour
{
    // Start is called before the first frame update
    int spriteValue = 0;
    public GameObject bulletSpawner;
    public GameObject muzzleSpawner;
    public SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    void Start()
    {
        
    }

    public void spriteChange(int sprite)
    {
        spriteValue = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (spriteValue == 0)
        {
           //transform.localScale = new Vector3(0.567f, 0.567f, 0.567f);
            //bulletSpawner.transform.position = new Vector3(1.58f, 0.68f, 0);
            //muzzleSpawner.transform.position = new Vector3(1.82f, -0.13f, 0);
            spriteRenderer.sprite = sprite1;
        }
        if (spriteValue == 1)
        {
            //transform.localScale = Vector3.one;
            //bulletSpawner.transform.position = new Vector3(2.42f, 0.23f, 0);
            spriteRenderer.sprite = sprite2;
        }
        if (spriteValue == 2)
        {
            spriteRenderer.sprite = sprite3;
        }
    }
}
