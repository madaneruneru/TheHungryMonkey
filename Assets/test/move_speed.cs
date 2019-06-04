using UnityEngine;
using System.Collections;

public class move_speed : MonoBehaviour
{

    public float moveSpeed = 0.5f;
    public Vector3 MoveTo = new Vector3(-5, 0, 0);
    public bool isDesoty = true;

    public void Awake()
    {
        //enabled = false; 

        Vector3 t1 = gameObject.transform.position;
        t1.x = t1.x + MoveTo.x;
        t1.y = t1.y + MoveTo.y;
        t1.z = t1.z + MoveTo.z;

        StartMove(t1);
    }

    float startTime, duration;
    Vector3 startPoint, endPoint;
    public void StartMove(Vector3 endPoint)
    {
        // pre calc all the lerp parameters
        startPoint = transform.position;
        this.endPoint = endPoint;
        duration = (endPoint - startPoint).magnitude / moveSpeed;
        startTime = Time.time;

        //enabled = true; // start updating the lerp
    }
    public void Update()
    {
        float time = Time.time - startTime; // time since start

        // interpolate position
        transform.position = Vector3.Lerp(startPoint, endPoint, time / duration);

        // full interpolation achieved
        if (time > duration)
        {
            //enabled = false;
            if (isDesoty == true)
            {
                Destroy(gameObject);
            }
        }
    }


}