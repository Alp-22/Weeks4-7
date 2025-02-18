using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sprite;
    [SerializeField]
    public AnimationCurve hitReg;
    public GameObject bulletSpawner;
    public BulletSpawner spawner;
    Color changeColor = new Color(0,0,0,255);
    float colorCurve;
    bool hit;
    int counter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawner = bulletSpawner.GetComponent<BulletSpawner>();
        for (int i = 0; i < spawner.spawnedBullets.Count; i++)
        {
            if (spawner.spawnedBullets[i] != null)
            {
                Vector3 bulletPos = spawner.spawnedBullets[i].transform.position;

                Vector3 dummyPos = transform.position;
                if (bulletPos.x <= dummyPos.x + 1f &&
                    bulletPos.x >= dummyPos.x - 1f &&
                    bulletPos.y <= dummyPos.y + 1f &&
                    bulletPos.y >= dummyPos.y - 1f)
                {
                    //spawner.bullet.enabled = false;
                    Destroy(spawner.spawnedBullets[i]);
                    Debug.Log("Hit");
                    hit = true;
                }
            }
        }
        Color color = new Color(0, 0, 0, 255);
        if (hit && counter<=255)
        {
            colorCurve = color.r + Time.deltaTime;
            changeColor.r += hitReg.Evaluate(colorCurve);
            sprite.color = changeColor;
            counter++;
        }
        else
        {
            colorCurve = 0f;
            changeColor = Color.black;
            counter = 0;
            hit = false;
            sprite.color = new Color(255, 255, 255);
        }
        
    }
}
