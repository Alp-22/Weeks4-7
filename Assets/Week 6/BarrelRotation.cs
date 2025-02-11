using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 turretRot = transform.eulerAngles;
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 dir = screenPos - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg; 
        //turretRot.z = mousePos.y*mousePos.x*-1;
        turretRot.z = angle;
        transform.eulerAngles = turretRot;
        //transform.Rotate(0, 0, angleInRadians);
    }
}
