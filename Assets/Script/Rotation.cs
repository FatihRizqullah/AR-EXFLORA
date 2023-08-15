using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 0.2f;

    void Update()
    {
        Rotation1();
    }

    private void Rotation1()
    {
        transform.Rotate(Vector3.back * speed);
    }
}
