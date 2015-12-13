using UnityEngine;
using System.Collections;

public class push : MonoBehaviour {
    //  public Transform startMarker;
    // public Transform endMarker;


    bool playerAt = false;
    bool bedMoved = false;
    public GameObject bed;
	// Use this for initialization
	void Start () {
  
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) == true && playerAt == true && bedMoved == false)
        {
            Debug.Log("should move");
            bedMoved = true; // animation won't happen again
             bed.GetComponent<Animator>().SetTrigger("KnockedOver"); // play pushing animation
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player") { 
        
            playerAt = true; // if the player is near, then the bed can be pushed
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            playerAt = false; // player is no longer near the bed
        }
    }
}
