using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerScore : MonoBehaviour
{
   [SerializeField] private int score = 0;                     // Variabele voor score
   public List<int> coins = new List<int>(); // Lijst voor munten

    void Start()
    {
        // Loop: toon 3x een startbericht
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Spel begint!");
        }
    }

    void Update()
    {
        // If-statement: check of score >= 50
        if (score >= 50)
          {
            Debug.Log("Je hebt gewonnen!");
        }

        // Test: druk op spatie om een munt toe te voegen
        if (Input.GetKeyDown(KeyCode.Space))
          {
            AddCoin(10); // Roep functie AddCoin() aan en geef als arguement 10 punten mee
            Debug.Log("Aantal munten: " + coins.Count);
         }
    }

    // Functie om een munt toe te voegen
    void AddCoin(int coinValue)
    {
        coins.Add(coinValue);      // Voeg munt toe aan lijst
        score += coinValue;        // Verhoog score met de waarde van coinValues
         Debug.Log("Munt gepakt! Score: " + score);
    }
}