﻿using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

// 继承：按下，抬起和离开的三个接口  
public class button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    public GameObject monkey;
    public float movementSpeed;
    // 延迟时间  
    private float delay = 0f ;

    // 按钮是否是按下状态  
    private bool isDown = false;

    // 按钮最后一次是被按住状态时候的时间  
    private float lastIsDownTime;



    void Update()
    {
        // 如果按钮是被按下状态  
        if (isDown)
        {
            // 当前时间 -  按钮最后一次被按下的时间 > 延迟时间0.2秒  
            if (Time.time - lastIsDownTime > delay)
            {
                // 触发长按方法  
                //Debug.Log("长按");
                // 记录按钮最后一次被按下的时间  
                //lastIsDownTime = Time.time;
                if(gameObject.tag =="BTN_L")//左
                {
                    monkey.gameObject.transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
                    lastIsDownTime = Time.time;
                }
                else if(gameObject.tag =="BTN_R")//右
                {
                    monkey.gameObject.transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
                    lastIsDownTime = Time.time;
                }
               

            }
        }

    }
    public void L()
    {
        if (gameObject.tag == "BTN_L")//左
        {
            monkey.gameObject.transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
            lastIsDownTime = Time.time;
        }
    }
    public void R()
    {
        if (gameObject.tag == "BTN_R")//右
        {
            monkey.gameObject.transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
            lastIsDownTime = Time.time;
        }
    }
    // 当按钮被按下后系统自动调用此方法  
    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = true;
        lastIsDownTime = Time.time;
    }

    // 当按钮抬起的时候自动调用此方法  
    public void OnPointerUp(PointerEventData eventData)
    {
        isDown = false;
    }

    // 当鼠标从按钮上离开的时候自动调用此方法  
    public void OnPointerExit(PointerEventData eventData)
    {
        isDown = false;
    }

}