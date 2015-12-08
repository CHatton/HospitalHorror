/*
    Written by Cian Hatton
    CHatton on GitHub
*/

using UnityEngine;
using System.Collections;

public class Doors : MonoBehaviour {
    Animator animator;
    AudioSource source; // the door opening sound
    bool doorOpen = false;

    void Start() {
        animator = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col) {

        if (col.gameObject.tag == "Player") {

            if (doorOpen == false) { // don't play if the door is open
                source.Play(); // play the audio if the door is closed
                doorOpen = true; // set the door to be open
            }
            
            animator.SetTrigger("Open");
        } // the door opens when a player enters
    } // OnTriggerEnter
} // Doors


