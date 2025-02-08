using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
   [SerializeField] float SteerSpeed = 1f;
   [SerializeField] float MoveSpeed = 15f;
   [SerializeField] float SlowSpeed =5f;
   [SerializeField] float BoostSpeed =30f;

   
    // void Start()
    // {
        
    // }

    void Update()
    {   
        // float MoveSpeed = 15;
        // float SteerSpeed = 250;
        float SteerAmount = Input.GetAxis("Horizontal") * SteerSpeed * Time.deltaTime;
        float SpeedAmount = Input.GetAxis("Vertical") * MoveSpeed *Time.deltaTime;
        transform.Rotate(0, 0, -SteerAmount);
        transform.Translate(0, SpeedAmount, 0);
        
    }
    void OnCollisionEnter2D(Collision2D other) {
         
            // float SpeedAmount = Input.GetAxis("Vertical") * SlowSpeed *Time.deltaTime;
            // transform.Translate(0, SpeedAmount, 0);
            MoveSpeed = SlowSpeed;

        }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost") {
            UnityEngine.Debug.Log("You got boosted!");
            // float SpeedAmount = Input.GetAxis("Vertical") * BoostSpeed *Time.deltaTime;
            // transform.Translate(0, SpeedAmount, 0);
            MoveSpeed = BoostSpeed;
        }
        
    }
}
