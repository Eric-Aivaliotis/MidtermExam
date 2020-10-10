using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public string NextScene;

    public void SwitchScene(string scene) //this just takes the name of the scene we want to switch to
    {
        SceneManager.LoadScene(scene);
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(NextScene);
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
