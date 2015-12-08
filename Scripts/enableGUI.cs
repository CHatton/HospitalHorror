/*
    Written by Cian Hatton
    CHatton on GitHub
*/

using UnityEngine;
using System.Collections;

public class enableGUI : MonoBehaviour {
    public Canvas c;
	// Use this for initialization
	void Start () {

        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            //don't use touch
            Debug.Log("on a desktop");
           // c.enabled = false;
           
        }
       
        else if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            // use touch input
            Debug.Log("on a handheld");
        }

    }
	

}
