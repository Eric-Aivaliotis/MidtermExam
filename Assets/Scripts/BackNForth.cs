using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackNForth : MonoBehaviour
{
    public Transform[] points;
    private int presentPoint;



 // Update is called once per frame
    void Update()
    {
        if (transform.position != points[presentPoint].position)
        {
            Vector3 location = Vector3.MoveTowards(transform.position, points[presentPoint].position, 5 * Time.deltaTime);

            GetComponent<Rigidbody>().MovePosition(location);
        }

        else
        {
            presentPoint = (presentPoint + 1) % points.Length;
        }
    }
}
