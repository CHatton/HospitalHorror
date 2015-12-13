using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class lastDoor : MonoBehaviour {
    public Text rec,point, credits;
    bool playerClose = false;
    bool soundPlayed = false;
    AudioSource[] sources;
    public GameObject mainMusic;
    AudioSource music;
    public Camera[] cams;
    public Camera enable;
    // Use this for initialization

    void Start() {
        sources = GetComponents<AudioSource>();
        music = mainMusic.GetComponent<AudioSource>();
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.E) && playerClose) {

            if (!soundPlayed) {
                soundPlayed = true;
                sources[0].Play(); // locked door
                sources[1].Play(); // scream
                music.Stop();
                
            }
            for (int i = 0; i < cams.Length; i++) {
                cams[i].enabled = false;
            }
            enable.enabled = true;
            rec.enabled = false;
            point.enabled = false;
            credits.enabled = true;
        }
	}

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            playerClose = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerClose = false;
        }
    }
}
