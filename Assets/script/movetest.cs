using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 用陀螺儀控制移動程式 */
public class movetest : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float z = transform.position.x; //x軸的位置
        //Debug.Log("x = " + z);

        //判斷角色x軸位置，使角色不超出螢幕範圍
        if (z > 8)
        {
            transform.Translate(-0.1f, 0, 0);
        }
        else if (z < -8)
        {
            transform.Translate(0.1f, 0, 0);
        }
        else
        {
            transform.Translate(Input.acceleration.x * 1.2f, 0, 0); //物件移動，判斷x軸的傾斜
        }

    }
}
