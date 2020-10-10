using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-5 * Input.GetAxis("Vertical") * Time.deltaTime, 0f, 5 * Input.GetAxis("Horizontal") * Time.deltaTime);
        //5 is the movement speed, I could have created a public float variable that controls the speed but I am just hardcoding this 
        //to save myself time

    }
}
