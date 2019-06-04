using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy : MonoBehaviour {
    //public static int live=3;
    void Start ()
    {  }

	void Update ()
    {}
	void OnCollisionEnter(Collision destroy)
	{
        
        
            if (destroy.collider.tag == "destroy") // when attach the destroy, then destroy the fruit 
            {
                Destroy(gameObject);
            }

            if (destroy.collider.tag == "monkey") // when attach the monkey, then destroy the fruit 
            {

                if (gameObject.tag == addscore.FruitTag)
                {
                    addscore.score += 5;//win
                                        
                    //Debug.Log("score=" + addscore.score);
                }
                else
                {
                    addscore.live--;   
                }
                Destroy(gameObject);
            }
        
    }
    

}