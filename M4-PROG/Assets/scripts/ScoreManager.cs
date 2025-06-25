using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // Zorg voor een logische startscore en maak deze aanpasbaar in de Inspector

    // Zorg dat de methode AddScore vanaf een ander script ook punten kan doorgeven als argument
    public void AddScore(int points)
    {
        // Tel de meegegeven punten op bij de score
        score += points;
        // Debug de score naar de console
        Debug.Log("Score bijgewerkt: " + score);
    }
}
