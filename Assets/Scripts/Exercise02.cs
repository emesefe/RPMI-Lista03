using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise02 : MonoBehaviour
{
    private bool IsEven(int num)
    {
        if (num % 2 == 0)
        {
            Debug.Log($"{num} is even");
            return true;
        }
        
        Debug.Log($"{num} is odd");
        return false;
    }
}
