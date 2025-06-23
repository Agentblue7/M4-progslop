using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed = 5f;          
    public GameObject coinPrefab;       

    void Start()
    {
        float randVal = Random.Range(-10, 10);
        Instantiate(coinPrefab, new Vector3(randVal, 0, 0), Quaternion.identity); 
    }

    void Update()
    {
       
        float input = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * speed * input * Time.deltaTime);
    }
}