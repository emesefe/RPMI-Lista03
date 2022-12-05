using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise07 : MonoBehaviour
{
    private float AbsoluteValue(float x)
    {
        if (x < 0)
        {
            // Si el número es negativo, lo cambiamos de signo y devolvemos su valor
            return -x;
        }

        return x;
    }
}
