using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public int x = 10;
    public int y = 4;
    private bool areEqual;

    public string name1 = "Eustaquio";
    public string name2 = "Celedonio";
    private bool areDifferent;

    public float xf = 2.0f;
    public float yf = 0.5f;
    private bool isGreater;
    

    private void Start()
    {
        areEqual = x == y;
        Debug.Log(areEqual);

        areDifferent = name1 != name2;
        Debug.Log(areDifferent);

        isGreater = xf > yf;
        Debug.Log(isGreater);

    }
}
