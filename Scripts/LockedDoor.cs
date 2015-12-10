/*
    Written by Cian Hatton
    CHatton on GitHub
*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LockedDoor : MonoBehaviour {
    Animator anim;
    private bool Door = false;
    public GameObject key; // GameObject that needs to be interacted with before the door can open
    AudioSource[] source = new AudioSource[2];
    AudioSource lockedDoor;
    AudioSource openDoor;
    bool hasPlayed = false;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        lockedDoor = GetComponents<AudioSource>()[0];
        openDoor = GetComponents<AudioSource>()[1];
    } // start
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.E)
            && Door == true
            && key.activeSelf == false) {
            anim.SetTrigger("Open"); // if the key has been taken and the user presses E the door will open
            openDoor.Play();
            // and the player is near the door
            //InfoText.info.text = "He just unlocked the door"; // update the text
        } else if (Input.GetKey(KeyCode.E)
            && Door == true
            && key.activeSelf == true
            && hasPlayed == false) { // key hasn't been picked up yet

            hasPlayed = true;
            lockedDoor.Play();
        }
	} // update

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player") {
            Door = true; // if the player is near, then the door can be opened
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            Door = false; // player is no longer near the door
            hasPlayed = false;
        }
        
    }
}
