using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    int rotation;

    // Start is called before the first frame update
    void Start()
    {
        rotation = 75;
        transform.Rotate(0, 0, rotation * Time.deltaTime);
        Debug.Log(rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
