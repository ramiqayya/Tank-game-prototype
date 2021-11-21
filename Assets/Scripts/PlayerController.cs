using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed=10;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.forward * speed*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.back * speed* Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.C))
        {
            transform.Rotate(Vector3.up );
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(Vector3.down);
        }

    }
}
