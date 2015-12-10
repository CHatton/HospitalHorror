/*
    Written by Cian Hatton
    CHatton on GitHub
*/

using UnityEngine;
using System.Collections;

public class changeColour : MonoBehaviour {
    public Color colour;
	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = colour;
        // change the colour of the object to red
	}
}
