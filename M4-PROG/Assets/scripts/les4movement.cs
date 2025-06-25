using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;         
    public ScoreManager scoreManager; 

    void Start()
    {
        if (scoreManager == null)
        {   
            Debug.LogError("ScoreManager niet ingesteld!");
        }
        Debug.Log("Snelheid: " + speed);
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 move = new Vector3(moveX, 0f, 0f);
        transform.Translate(move);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check of het een munt is
        if (other.name == "coin")
        {
            scoreManager.AddScore(10); // Roep de AddScore methode aan en geef 10 punten mee

            // Geef in de console een bericht dat je een munt hebt gepakt!
            Debug.Log("Munt gepakt!");

           
            Destroy(other.gameObject);
        }
    }
}