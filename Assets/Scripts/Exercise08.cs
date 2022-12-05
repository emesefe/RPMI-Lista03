using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise08 : MonoBehaviour
{
    private bool IsLeapYear(int y)
    {
        if (y % 4 == 0)
        {
            if (y % 100 == 0)
            {
                if (y % 400 == 0)
                {
                    Debug.Log($"{y} is a leap year");
                    return true;
                }
                else
                {
                    Debug.Log($"{y} is not a leap year");
                    return false;
                }
            }
            else
            {
                Debug.Log($"{y} is not a leap year");
                return false;
            }
        }
        
        Debug.Log($"{y} is a leap year");
        return true;
        
    }
}
