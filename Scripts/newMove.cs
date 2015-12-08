/*
    Edited by Cian Hatton
    CHatton on GitHub
*/

using UnityEngine;
using System.Collections;
using CnControls;

[RequireComponent(typeof(CharacterController))]
public class newMove : MonoBehaviour
{
    Animator anim;
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;
    // assigned speed for the animations

    void Start() {

        anim = GetComponent<Animator>();
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        transform.Rotate(0, CnInputManager.GetAxis("Horizontal") * rotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * CnInputManager.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);


        if (SystemInfo.deviceType == DeviceType.Desktop) {
            // Walking animations
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
        } else if (SystemInfo.deviceType == DeviceType.Handheld) {
            GetComponent<Animation>().Play("walk");
            // if the controls are touched at all the walking animation plays
        }
   
        if (!Input.anyKey)
        { // if no button is being pressed, play the idle animation
            GetComponent<Animation>().Play("idle");
        }

    }
}