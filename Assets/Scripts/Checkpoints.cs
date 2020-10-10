using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "checkpoint1")
            {
                Destroy(collision.gameObject);
            //gameObject.GetComponent<PluginHabdler>().SaveTimwTest(Time.time);
            }

            if (collision.gameObject.name == "checkpoint2")
            {
                Destroy(collision.gameObject);
            }

            if (collision.gameObject.name == "checkpoint3")
            {
                Destroy(collision.gameObject);
            }

            if (collision.gameObject.name == "checkpoint4")
            {
                Destroy(collision.gameObject);
            }

            if (collision.gameObject.name == "checkpoint5")
            {
                Destroy(collision.gameObject);
            }
        }
    

   
}
