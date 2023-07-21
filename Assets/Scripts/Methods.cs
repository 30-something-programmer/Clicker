using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{

    int ApplyDamage(int damageTaken, int health)
    {
        // Int that receives damage and current health to return player health
        return health - damageTaken;
    }

    void Start()
    {
        // Start runs at init
        Debug.Log("Methods class started.");

        // Generate int x to hold damage
        int x = ApplyDamage(5, 100);

        Debug.Log("Snakeyboi health is: " + x);

    }

    void Update()
    {
        // Update runs once per frame

    }
}
