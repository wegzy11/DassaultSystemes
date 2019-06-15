using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        transform.Rotate(0, speed, 0, Space.Self);
    }
}
