using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     float PlayerSpeed; 
    [SerializeField] float CurrentTimeToSpeed;
    [SerializeField] float StartimerToSpeed;
    [SerializeField] float incrementSetHere;
   

    [SerializeField] KeyCode links;
    [SerializeField] KeyCode rechts;
    [SerializeField] KeyCode omhoog;
    [SerializeField] KeyCode onder;
    [SerializeField] SpriteRenderer spriteturn;
   
    
    private Rigidbody2D RB;
    bool StartTimer;
    
    void Start()
    {
        CurrentTimeToSpeed = StartimerToSpeed;
        PlayerSpeed = 1f;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * PlayerSpeed * Time.deltaTime);
            
            StartTimer = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * PlayerSpeed * Time.deltaTime);
            
            StartTimer = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * PlayerSpeed * Time.deltaTime);
            
            StartTimer = true;

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * PlayerSpeed * Time.deltaTime);
           
            StartTimer = true;

        }
        if (Input.GetKeyUp(links))
        {          
            StartTimer = false;
        }
        if (Input.GetKeyUp(rechts))
        {          
            StartTimer = false;
        }
        if (Input.GetKeyUp(omhoog))
        {          
            StartTimer = false;
        }
        if (Input.GetKeyUp(onder))
        {
            StartTimer = false;
        }

        if (StartTimer == true)
        {
            CurrentTimeToSpeed -= incrementSetHere * Time.deltaTime;
            if (CurrentTimeToSpeed == 10)
            {
                PlayerSpeed = 1f;
            }
            if (CurrentTimeToSpeed == 9)
            {
                PlayerSpeed++;
            }
            if (CurrentTimeToSpeed == 8)
            {
                PlayerSpeed++;
            }
            if (CurrentTimeToSpeed == 7)
            {
                PlayerSpeed++;
            }
            if (CurrentTimeToSpeed == 6)
            {
                PlayerSpeed++;
            }
        }
        else if(StartTimer == false)
        {
            CurrentTimeToSpeed = StartimerToSpeed;
        }


        Debug.Log("ThisIsSpeed " + PlayerSpeed);



    }

    

}
