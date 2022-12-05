using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    private void DivisionIsExact(int dividend, int divisor)
    {
        if (dividend % divisor == 0)
        {
            Debug.Log("The division is exact");
        }
        else
        {
            Debug.Log("The division is not exact");
        }
    }
}
