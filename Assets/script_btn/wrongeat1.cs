using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class wrongeat1 : MonoBehaviour {
    public Text eattext;
    public GameObject text;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (addscore1.live==4)
        {
            eattext.text.ToString();
            text.gameObject.SetActive(true);
        }
	}
}
