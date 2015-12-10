/*
    Written by Cian Hatton
    CHatton on GitHub
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class initGame : MonoBehaviour {

    public GameObject player;

    public Canvas info;
    public Canvas rec;
    public Canvas touchPad;
    public Text introText;
    public Text title;

    public Camera thisCamera;
    public Camera cam1;

    bool scriptFinshed = false;

	// Use this for initialization
	void Start () {
        if (SystemInfo.deviceType == DeviceType.Desktop) {
            introText.text = "Press ENTER to begin recording...";
            // different message depending on platform
        } else if (SystemInfo.deviceType == DeviceType.Handheld) {
            introText.text = "Tap screen to begin recording...";
            // different message depending on platform
        }
        player.SetActive(false); // disable player until they press a button
    }
	
	// Update is called once per frame
	void Update () {
        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            if (Input.GetKey("return") == true && scriptFinshed == false)
                // stop camera switching when game has begun
            {
                rec.enabled = true; // enable the top right REC
                thisCamera.enabled = false; // disable the black camera
                cam1.enabled = true; // enable the starting camerage
                introText.text = ""; // set the text to start off as an empty String
                player.SetActive(true); // activate the player
                title.text = ""; // disable the title text
                scriptFinshed = true; // trigger game to start
            }
        }
        else if (SystemInfo.deviceType == DeviceType.Handheld)
        {// touch

            
            if (Input.touchCount > 0 && scriptFinshed == false/*Input.GetMouseButtonDown(0) - test with mouse keyboard*/)
            {
                
                touchPad.enabled = true; // enable the touch controls
    
                rec.enabled = true; // enable the top right REC
                thisCamera.enabled = false; // disable the black camera
                cam1.enabled = true; // enable the starting camerage
                introText.text = ""; // set the text to start off as an empty String
                player.SetActive(true); // activate the player
                title.text = ""; // disable the title text
                scriptFinshed = true; // trigger game to start
            }
        }
    }
}
