using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private int playerWheels = 4; // Wheels' variable saves the vehicle's wheels number

    [SerializeField] private string name = "";

    [SerializeField] private bool isOn;

    public string sound;

    [SerializeField] private float gasoline;

    private void Start()
    {
        Debug.Log($"{name} tiene {playerWheels} ruedas");

        if (isOn == false)
        {
            Debug.Log($"{name} está apagado");
        }
        else if (isOn == true) if (sound != "")

        {
            Debug.Log($"{name} está encendido y hace Brum Brum");
        }
        else
        { 
            Debug.Log($"{name} está en marcha");
        }

        if (isOn == true && gasoline <= 10)
        {
            Debug.Log($"¡A {name} le queda poca gasolina!"); 
        }
    }

}
