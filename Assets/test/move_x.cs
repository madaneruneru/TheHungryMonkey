using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move_x : MonoBehaviour {
    // Use this for initialization
    void Start ()
    { 
        	
	}
	
	// Update is called once per frame
	void Update ()
    {
        float z= transform.position.x;
        Debug.Log("x = "+z);
        if (z > 140)
        {
            transform.Translate(-0.1f, 0, 0);
        }
        else if (z < -140)
        {
            transform.Translate(0.1f, 0, 0);
        }
        else
        {
            transform.Translate(Input.acceleration.x * 10, 0, 0);
        }
        
    }

}
