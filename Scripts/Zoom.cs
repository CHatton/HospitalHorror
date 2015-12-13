using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour {
    const int zoomAmount = 10;
    bool playerIn = false;
    bool hasZoomed = false;
    bool hasZoomedOut = false;
    public Camera cam;
    AudioSource source;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (hasZoomed == false && playerIn == true) {
            hasZoomed = true;
            cam.fieldOfView -= zoomAmount;
            source.Play();
        }

	}

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            playerIn = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIn = false;
            if (hasZoomed == true && hasZoomedOut == false) {
                hasZoomedOut = true;
                cam.fieldOfView += zoomAmount;
                source.Play();
            }
        }
    }
}
