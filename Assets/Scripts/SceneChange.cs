using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
       
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("The current scene is" + scene);
        Debug.Log("I have been hit.");//Checks to see if trigger has been activated. 
        Debug.Log(other.tag);//Checks what tag the gameobject has

        if(other.tag == "Player")//If the object that collided with the tag "player" hits the cube
        {
            SceneManager.LoadScene("SampleScene");//Then the player is transported to another scene.
        }
        if(scene.name== "SampleScene")
        {
            SceneManager.LoadScene("PostProcessScene");
        }
    }
   
}
