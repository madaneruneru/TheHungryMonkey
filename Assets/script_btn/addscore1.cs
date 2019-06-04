using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class addscore1 : MonoBehaviour
{
    public static int score = 0, level = 24, prilevel = 24, live = 5;
    static public string FruitTag = "banana";
    public GameObject[] livefruit = new GameObject[5];
    private bool isGameOver = false;
    public GameObject pause, button_left, button_right, gameover, monkey, live_ui, live_content;
 

    // Use this for initialization
    void Start()
    {
        isGameOver = false;
        live = 5;
        score = 0;
        FruitTag = "banana";
        level = 24;
        prilevel = 24;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            for (int i = 0; i < 5; i++)
            {
                if (FruitTag == livefruit[i].tag)
                {
                    livefruit[i].SetActive(true);
                }
            }
            if (score > level)
            {
                if (level < 25) { level += 25; }
                else if (score >= 50 ||score < 75 ) { level+=20; }
                else if(score >= 75 || score < 100 ) { level+=15; }
                else if (score >= 500 || score < 700) { level += 10; }
                else { level += 5; }
            }
            if (live <= 0)
            {
                isGameOver = true;
                Time.timeScale = 0;

                //Debug.Log("?" + score); 
                PlayerPrefs.SetInt("模式一", score);
                PlayerPrefs.Save();

            }
        }
    }

    void OnGUI()
    {
        if (isGameOver == true)
        {
            pause.gameObject.SetActive(false);
            button_left.gameObject.SetActive(false);
            button_right.gameObject.SetActive(false);
            gameover.gameObject.SetActive(true);
            monkey.gameObject.SetActive(false);
            live_content.gameObject.SetActive(false);
            live_ui.gameObject.SetActive(false);

           
        }
    }
}
