using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    public float x = 7f;
    public float y = 4f;

    public float num1 = 7f;
    public float num2 = 4f;
    private void Calculator(float num1 , float num2)
    {
        Debug.Log($"Sum: {num1} + {num2} = {num1 + num2}");
        Debug.Log($"Substraction: {num1} - {num2} = {num1 - num2}");
        Debug.Log($"Product: {num1} * {num2} = {num1 * num2}");
        Debug.Log($"Division: {num1} / {num2} = {num1 / num2}");
    }

    
    private void Start()
    {
       
        Debug.Log(x + y);
        Debug.Log(x - y);     
        Debug.Log(x * y);
        Debug.Log(x / y);
        Debug.Log(x % y);

    }
    
}
