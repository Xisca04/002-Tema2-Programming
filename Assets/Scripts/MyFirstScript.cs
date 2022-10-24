using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
     4 variables with the player information 
     */

    public int playerAge = 33; 
    public float playerSpeed = 3.125f; // This variable saves the player's speed
    public string playerName = "Xisca"; 
    public bool isGameOver = false; // This variable saves if the player has lost

    public string message = "Hola mundo";
    public int points = 256;

    public float x = 2;
    public float y = 3;
    private float result;

    private void Start()
    {
        Debug.Log(message);
        Debug.Log(points);
        Debug.Log($"Tengo {points} puntos");
        Debug.Log(string.Format("Tengo {0} puntos", points));
        Debug.Log(string.Format("Hola {0}, tienes {1} puntos", playerName, points));
        Debug.Log("Tengo " + points + " puntos");

        result = x + y;
        Debug.Log(result);
    }
}
