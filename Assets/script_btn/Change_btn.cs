using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_btn : MonoBehaviour
{

    public GameObject[] Fruits = new GameObject[4];

    int i = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (addscore1.FruitTag != gameObject.tag)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }

        if (addscore1.level > addscore1.prilevel)
        {
            i = Random.Range(0, 4);
            /*Instantiate(Fruits[i],gameObject.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);*/
            //gameObject.SetActive(false);
            addscore1.FruitTag = Fruits[i].tag;
            addscore1.prilevel = addscore1.level;
        }

    }
}