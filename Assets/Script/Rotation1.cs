using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation1 : MonoBehaviour
{
    public float speed = 0.2f;

    void Update()
    {
        Rotation2();
    }

    private void Rotation2()
    {
        transform.Rotate(Vector3.down * speed);
    }
}
