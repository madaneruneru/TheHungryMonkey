using UnityEngine;
using System.Collections;

public class spwan : MonoBehaviour
{



    public float spawnTime = 3f;            // How long between each spawn.
    public GameObject appleReference;

    // Use this for initialization
    void Start()
    {

        InvokeRepeating("SpawnFruit", spawnTime, spawnTime);  // add apple
    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnFruit()
    {


        Vector3 t1 = transform.position;

        //GameObject fruit = Instantiate(appleReference, t1, transform.rotation) as GameObject;
        //	fruit.GetComponent<Rigidbody>().AddForce(throwForce, ForceMode.Impulse);

        //	fruit.transform.Rotate(  Random.Range(-360, 360)  ,Random.Range(-360, 360)
        //	                       ,Random.Range(-360, 360) );


        //}
    }

}
