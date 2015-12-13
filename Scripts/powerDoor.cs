/*
    Written by Cian Hatton
    CHatton on GitHub
*/

using UnityEngine;
using System.Collections;

public class powerDoor : MonoBehaviour
{
    Animator anim;
    AudioSource[] sources = new AudioSource[2];
    bool doorOpen = false;
    AudioSource open;
    AudioSource locked;
    bool hasPlayed = false;
    bool playerNear = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        open = GetComponents<AudioSource>()[0];
        locked = GetComponents<AudioSource>()[1];
    }

    void Update() {
        if (Input.GetKey(KeyCode.E) == true // player interacted with it
            && playerNear == true // player is near door
            && activateDoor.switchPressed == true) // player has hit switch
        {
            anim.SetTrigger("Open");
            open.Play();
        } else if (Input.GetKey(KeyCode.E) == true // player interacted with it
            && playerNear == true // player is near door
            && activateDoor.switchPressed == false
            && hasPlayed == false) { // haven't pressed the switch
            hasPlayed = true;
            locked.Play();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            playerNear = true;
            
        }

    } // OnTriggerEnter

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            hasPlayed = false;
            playerNear = false;

        }
    } // OnTriggerExit
}

