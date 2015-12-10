using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class key : MonoBehaviour {
    public GameObject TheKey;
    bool playerNextToKey = false;

    void Update() {
        if (Input.GetKeyDown(KeyCode.E) && playerNextToKey == true) {
            TheKey.SetActive(false);           
        }
    } // Update

    void OnTriggerEnter(Collider col){     
        if (col.tag == "Player") {
            playerNextToKey = true;
        }
    } // OnTriggerEnter

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            playerNextToKey = false;
        }
    } // OnTriggerExit

} // Key

