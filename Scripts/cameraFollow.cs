/*
    Written by Cian Hatton
    CHatton on GitHub
*/

using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

    public Transform target;
    void Start() {
       
    }
	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
	}
    /*
    makes the camera follow the target
    provided, in this case the player character
    */
}
