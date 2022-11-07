using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    public Vector3 subir = new Vector3(0, 1, 0);

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position += subir;
        } 
    }
}
