using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float Speed = 5;
    public float Rotation = 5;

    // Start is called before the first frame update
    void FixedUpdate()
    {
       
        if (Input.GetKey("d"))
            this.transform.Rotate(0, 0, -Rotation / 50);
        if (Input.GetKey("a"))
            this.transform.Rotate(0, 0, Rotation / 50);
        if (Input.GetKey("w"))
            this.transform.Translate(Speed / 50, 0, 0);
        if (Input.GetKey("s"))
            this.transform.Translate(-Speed / 50, 0, 0);
    }
}
