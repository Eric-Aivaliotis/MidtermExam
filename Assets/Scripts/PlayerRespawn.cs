using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private Transform character;
    [SerializeField] private Transform checkpointBase;


    private void OnTriggerEnter(Collider hitBymovingWall)
    {
        if (hitBymovingWall.CompareTag("Player"))
        {
            character.transform.position = checkpointBase.transform.position;
            Physics.SyncTransforms();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
