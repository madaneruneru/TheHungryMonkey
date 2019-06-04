using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score1_ui : MonoBehaviour {
    public float score_content;
    public Text scoretext;
	// Use this for initialization
	void Start ()
    {
       
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		scoretext.text = addscore1.score.ToString();    
    }
    
}
