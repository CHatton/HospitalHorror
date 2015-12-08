/*
    Edited by Cian Hatton
    CHatton on GitHub
*/

using UnityEngine;
using System.Collections;

public class playerTouchControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1)
        {
            var touch = Input.touches[0];

            if (touch.position.x < Screen.width / 2 
                && touch.position.y > Screen.height / 4
                && touch.position.y < Screen.height *(3/4))
            {
                GetComponent<Animation>().Play("walk"); // left
            }
            else if (touch.position.x > Screen.width / 2
                && touch.position.y > Screen.height / 4
                && touch.position.y < Screen.height * (3 / 4))
            {
                GetComponent<Animation>().Play("walk"); // right
            }
        } // one touch

        
    }
}
