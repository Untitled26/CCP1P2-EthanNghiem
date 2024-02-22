using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 6.5f;

        transform.Translate(0, speed * Time.deltaTime, 0);

        Debug.Log(speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
