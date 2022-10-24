using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    public float x = 7f;
    public float y = 4f;

    private void Start()
    {
       
        Debug.Log(x + y);

        
        Debug.Log(x - y);

       
        Debug.Log(x * y);

       
        Debug.Log(x / y);

       
        Debug.Log(x % y);

    }
}
