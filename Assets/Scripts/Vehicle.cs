using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private int playerWheels = 4; // Wheels' variable saves the vehicle's wheels number

    [SerializeField] private string name = "";

    private void Start()
    {
        Debug.Log($"{name} tiene {playerWheels} ruedas");
    }
}
