/*
    Written by Cian Hatton
    CHatton on GitHub
*/

using UnityEngine;
using System.Collections;

public class cameraSwitch : MonoBehaviour {

    public Camera[] allCams; // create an array to store all the cameras
    public Camera enableCam; // this is the camera that will be enabled
  
    void OnTriggerEnter(Collider col) {

        if (col.tag.Equals("Player")) { // when the player enters this trigger

        
            if (!enableCam.enabled) {
                AudioSource source = GetComponent<AudioSource>();
                source.Play();
                /*
                 this ensures that the audio only plays
                 if there is a change in the camera that is activating.
                 Otherwise there would be a sound even if the same camera
                 was being activated.
                */
            }

            for (int i = 0; i < allCams.Length; i++) {
                allCams[i].enabled = false; // disable all cameras
            }

            enableCam.enabled = true; // enable the camera that's been chosen to activate

        } // on collision with player
    } // onTriggerEnter

    void Update() {

  
    }
}
