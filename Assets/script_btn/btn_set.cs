using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_set : MonoBehaviour {
    public GameObject panel;

	// Use this for initialization
	void Start ()
    {
       Time.timeScale = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
    public void close_panel()
    {
        panel.gameObject.SetActive(false);
        Time.timeScale = 1;
       
    }
}
