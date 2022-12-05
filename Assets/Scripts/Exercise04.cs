using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{
    private void MoveToDirection(Vector3 direction)
    {
        transform.position += direction;
    }
}
