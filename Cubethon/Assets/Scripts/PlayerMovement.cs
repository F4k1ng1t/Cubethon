using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody rb;
    public GameObject wheel1;
    public GameObject wheel3;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public bool moveRight = false;
    public bool moveLeft = false;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (moveRight)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            this.transform.rotation = Quaternion.Euler(0, 45, 0);
            //Debug.Log("Move Right");
            
            
        }
        if (moveLeft)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            this.transform.rotation = Quaternion.Euler(0, -45, 0);
            //Debug.Log("Move Left");
        }
        if (!moveRight && !moveLeft)
        {
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            //Debug.Log("None");
        }
        
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
    private void Update()
    {
        if (Input.GetKey("d"))
        {
            moveRight = true;

        }
            
        else
        {
            moveRight = false;

        }
            
        if (Input.GetKey("a"))
        {
            moveLeft = true;
        }

        else
        {
            moveLeft = false;
        }
            
        

    }
}
