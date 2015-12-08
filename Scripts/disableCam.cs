/*
    Written by Cian Hatton
    CHatton on GitHub
*/

using UnityEngine;
using System.Collections;

public class disableCam : MonoBehaviour {

    public Camera thisCam; // the camera to be disabled

	// Use this for initialization
	void Start () {
        thisCam.enabled = false; // disable the camera when the game starts
	}
	
}
