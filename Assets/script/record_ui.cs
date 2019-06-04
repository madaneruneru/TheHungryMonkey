using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class record_ui : MonoBehaviour {
    public float record_content;
    public Text recordtext;
    private int highscore, recordscore;

    // Use this for initialization
    void Start ()
    {
        recordscore = PlayerPrefs.GetInt("紀錄2");
        recordtext.text = recordscore.ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
        highscore = PlayerPrefs.GetInt("模式二");
        if (addscore.score > recordscore)
        {
            recordtext.text = highscore.ToString();
            PlayerPrefs.SetInt("紀錄2", highscore);
            PlayerPrefs.Save();
        }
    }
}
