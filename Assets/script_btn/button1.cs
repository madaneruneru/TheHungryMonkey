using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;


public class Buttom_TLR : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    GameObject player;

    private float delay = 0f;


    private bool isDown = false;


    private float lastIsDownTime;
    void Start()
    {
        player = GameObject.Find("Sphere");
    }


    void Update()
    {
        if (isDown)
        {
            if (Time.time - lastIsDownTime > delay)
            {
                if (gameObject.tag == "BT_TL")
                {
                    player.transform.Rotate(new Vector3(0f, 3f, 0f));
                    lastIsDownTime = Time.time;
                }

                if (gameObject.tag == "BT_TR")
                {
                    player.transform.Rotate(new Vector3(0f, -3f, 0f));
                    lastIsDownTime = Time.time;
                }

            }
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = true;
        lastIsDownTime = Time.time;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isDown = false;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        isDown = false;
    }
    public void TL()
    {
        if (gameObject.tag == "BT_TL")
        {
            player.transform.Rotate(new Vector3(0f, 3f, 0f));
        }
    }
    public void TR()
    {
        if (gameObject.tag == "BT_TR")
        {
            player.transform.Rotate(new Vector3(0f, -3f, 0f));
        }
    }
}
