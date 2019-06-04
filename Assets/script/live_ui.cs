using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class live_ui : MonoBehaviour
{
    public float live_content;
    public Text livetext;
    public GameObject text, text1, text2, text3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        livetext.text = addscore.live.ToString();

        if (addscore.live == 4)
        {
            text.gameObject.SetActive(true);
            Destroy(text.gameObject, 0.25f);
        }
        else if (addscore.live == 3)
        {
            text1.gameObject.SetActive(true);
            Destroy(text1.gameObject, 0.25f);
        }
        else if (addscore.live == 2)
        {
            text2.gameObject.SetActive(true);
            Destroy(text2.gameObject, 0.25f);
        }
        else if (addscore.live == 1)
        {
            text3.gameObject.SetActive(true);
            Destroy(text3.gameObject, 0.25f);
        }
    }
}
