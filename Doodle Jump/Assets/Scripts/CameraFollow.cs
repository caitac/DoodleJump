using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 

    private void LateUpdate() //unity has different types of updates! 
    //if the behavior is enabled lateupdate will be called after all update functions 
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPosition; //updates the position of the player
        }
    }
}
