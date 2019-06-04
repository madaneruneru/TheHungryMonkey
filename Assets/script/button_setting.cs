using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //新增此行


public class button_setting : MonoBehaviour {
    public AudioSource music;
    public float musicVolume;
    public Text ButtonTest;
    public GameObject panel;
    public GameObject monkey;
    public GameObject panel1, panel_rule;
    public float movementSpeed;
    
    public void GameStart()
    {
        //Application.LoadLevel(1);
        // SceneManager.LoadScene("canva"); //輸入場景名稱
        panel1.gameObject.SetActive(true);
        
    }

    public void GameQuit() //離開遊戲，要匯出才有效果
    {
        Application.Quit();
    }

    public void Go_canva()
    {
        
         SceneManager.LoadScene("canva"); //輸入場景名稱

    }

    public void Go_Btgm()
    {
        SceneManager.LoadScene("btn_game");

    }

    public void Rule()
    {
        SceneManager.LoadScene("rule"); //輸入場景名稱
    }
    public void BackHome()
    {
        SceneManager.LoadScene("home"); //Load the scene of home.
    }

    public void MusicPause()
    {
        music.Pause();
    }

    public void ChangeButton()
    {
              
        if (ButtonTest.text == "Music Start")
        {
            ButtonTest.text = "Music Close";
            music.Play();
         }
        else if (ButtonTest.text == "Music Close")
        {
            ButtonTest.text = "Music Start";
            music.Pause();
        }

    }
    public void OpenPanel()
    {
        panel.gameObject.SetActive(true);
        Time.timeScale = 0;
        monkey.SetActive(false);
    }

    public void ClosePanel()
    {
        panel.gameObject.SetActive(false);
        Time.timeScale = 1;
        monkey.SetActive(true);
    }

    public void Back_closepanel()
    {
        panel1.gameObject.SetActive(false);
    }

    public void Move_Right()
    {
        //monkey.gameObject.transform.Translate(movementSpeed, 0, 0);
        monkey.gameObject.transform.Translate(movementSpeed, 0, 0);
    }

    public void Move_Lift()
    {
        //monkey.gameObject.transform.Translate(-1 * movementSpeed, 0, 0);
       // monkey.gameObject.transform.eulerAngles = new Vector3(0, 270, 0);
        monkey.gameObject.transform.Translate(-movementSpeed*Time.deltaTime, 0, 0);
    }

    public void open_exitpanel()
    {
        panel.gameObject.SetActive(true);
    }

    public void close_panel()
    {
        panel_rule.gameObject.SetActive(false);
        
    }

    /*public void ChangeButton2()
    { 
        if (ButtonTest.text == "Music Close")
        {
            ButtonTest.text = "Music Start";
            music.Pause();
        }
        //ButtonTest.text = "Music Close";
    }*/
    // Use this for initialization
    void Start ()
    {
        musicVolume = 0.5F;
        Time.timeScale = 1;
        movementSpeed = 5.0f;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}