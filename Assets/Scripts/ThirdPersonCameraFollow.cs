using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraPosition;  //the position of the camera relative to the player
    public float followSpeed = 0.15f;


     void LateUpdate()  //This is so not to compete with the other update functions
    {
        transform.position = player.position + cameraPosition;
    }
}
