using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float Speed = 5;
    public float Rotation = 5;

    // Start is called before the first frame update
    void FixedUpdate()
    {

        if (Input.GetKey("right"))
            this.transform.Rotate(0, 0, -Rotation / 50);
        if (Input.GetKey("left"))
            this.transform.Rotate(0, 0, Rotation / 50);
        if (Input.GetKey("up"))
            this.transform.Translate(Speed / 50, 0, 0);
        if (Input.GetKey("down"))
            this.transform.Translate(-Speed / 50, 0, 0);
    }
}
