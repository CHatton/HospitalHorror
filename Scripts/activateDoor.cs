using UnityEngine;
using System.Collections;

public class activateDoor : MonoBehaviour {
    AudioSource source;
    bool playerAt = false;
    public static bool switchPressed = false;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.E) && playerAt == true && switchPressed == false )
        {
            switchPressed = true;
            source.Play(); // play the audio
        }
    } // update

    void OnTriggerEnter(Collider col) {
        if (col.tag == "Player")
        {

            playerAt = true; // if the player is near, then the door can be opened
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
  
            playerAt = false; // player is no longer near the door
        }
    }
}
