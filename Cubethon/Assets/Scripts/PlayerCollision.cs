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
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
