using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelturn : MonoBehaviour
{
    public PlayerMovement player;
    public GameObject wheel1;
    public GameObject wheel3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.moveRight == true)
        {
            wheel1.transform.localRotation = Quaternion.Euler(wheel1.transform.localRotation.eulerAngles.x, 45, -90);
            wheel3.transform.localRotation = Quaternion.Euler(wheel3.transform.localRotation.eulerAngles.x, 45, -90);
            //Debug.Log("Right");
        }
            
        if (player.moveLeft == true)
        {
            wheel1.transform.localRotation = Quaternion.Euler(wheel1.transform.localRotation.eulerAngles.x, -45, -90);
            wheel3.transform.localRotation = Quaternion.Euler(wheel3.transform.localRotation.eulerAngles.x, -45, -90);
            //Debug.Log("Left");
        }

        if (player.moveLeft == false && player.moveRight == false)
        {
            wheel1.transform.localRotation = Quaternion.Euler(wheel1.transform.localRotation.eulerAngles.x, 0, -90);
            wheel3.transform.localRotation = Quaternion.Euler(wheel3.transform.localRotation.eulerAngles.x, 0, -90);
            //Debug.Log("None");
        }

    }
}
