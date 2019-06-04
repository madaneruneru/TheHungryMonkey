using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour {

    public GameObject[] Fruits = new GameObject[4];

    int i=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(addscore.FruitTag != gameObject.tag)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }

        if (addscore.level > addscore.prilevel)
        {
            i = Random.Range(0, 4);
            /*Instantiate(Fruits[i],gameObject.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);*/
            //gameObject.SetActive(false);
            addscore.FruitTag = Fruits[i].tag;
            addscore.prilevel = addscore.level;
        }

	}
}
