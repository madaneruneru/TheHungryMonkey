using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float movementSpeed ;
    public float minPosX;
    public float maxPosX;

    // Use this for initialization
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       
       
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-1 * movementSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(movementSpeed, 0, 0);
        }
        float z = transform.position.x;
        Debug.Log("x=" + z);
        
        float movement = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        //新的座標

        Vector3 newPos = new Vector3(Mathf.Clamp(transform.position.x + movement, minPosX, maxPosX), transform.position.y, transform.position.z);

        //把座標設為新的座標
        transform.position = newPos;
    }

}