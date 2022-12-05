using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise09 : MonoBehaviour
{
    private void TriangleArea(float b, float h)
    {
        if (b > 0 && h > 0)
        {
            Debug.Log($"The area is {b * h / 2}");
        }
        else
        {
            Debug.Log("The calculations cannot be carried out");
        }
    }
}
