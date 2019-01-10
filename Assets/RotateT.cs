using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateT : MonoBehaviour
{
    public void Rotation(float Degrees)
    {
        transform.Rotate(0, 0, Degrees);
    }
}
