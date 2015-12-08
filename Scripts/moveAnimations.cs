using UnityEngine;
using System.Collections;

public class moveAnimations : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        { 
            GetComponent<Animation>().Play("walk");
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Animation>().Play("walk");
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Animation>().Play("walk");
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
             GetComponent<Animation>().Play("walk"); // unfortunately no walking backwards animation
         }
        /*
        if (!Input.anyKey) { // if no button is being pressed, play the idle animation
            GetComponent<Animation>().Play("idle");
        }
        */
    } // update
}
