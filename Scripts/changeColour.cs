/*
    Written by Cian Hatton
    CHatton on GitHub
*/

using UnityEngine;
using System.Collections;

public class changeColour : MonoBehaviour {
   

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = Color.red;
        // change the colour of the object to red
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
