using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
            playerMovement.enabled = false;
            if(collision.rigidbody != null)
                collision.rigidbody.AddForce(0, 5000, 10000);
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
