using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy_btn : MonoBehaviour
{
    public GameObject text;
    //public static int live=3;
    void Start()
    { }

    void Update()
    { }
    void OnCollisionEnter(Collision destroy)
    {


        if (destroy.collider.tag == "destroy") // when attach the destroy, then destroy the fruit 
        {
            Destroy(gameObject);
        }

        if (destroy.collider.tag == "monkey") // when attach the monkey, then destroy the fruit 
        {

            if (gameObject.tag == addscore1.FruitTag)
            {
                addscore1.score += 5;//win

                Debug.Log("score=" + addscore1.score);
            }
            else
            {
                addscore1.live--;
            }
            Destroy(gameObject);
        }

    }


}