using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    float Horzinp;
    float Vertinp;

    int speed = 1;

    Rigidbody RB;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Horzinp = Input.GetAxis("Horizontal");
        Vertinp = Input.GetAxis("Vertical");

        transform.Translate(Horzinp * speed * Time.deltaTime, 0, Vertinp * speed * Time.deltaTime);

        /*
        if(Input.GetButtonDown("Jump"))
        {
            RB.Addforce(Vector3.up * 5, ForceMode.Impulse);
        }*/
    }
}
