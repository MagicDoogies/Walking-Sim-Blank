using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    
    public static DontDestroy Instance= null;// A boolean to determine whether the script exists in a given scene already. 
    void Awake()
    {
        if(Instance== null)//If the script doesn't exist in a scene-
        {
            Instance= this;//create the script and game object. Otherwsie-
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance !=null)//If a copy of it already exists-
        {
            Destroy(gameObject);// Destroy the gameobject and script coming over to the scene. 
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
