using UnityEngine;
using System.Collections;

public class makeGreen : MonoBehaviour {
    public Light light1;
    public Light light2;
  
	
	// Update is called once per frame
	void Update () {
        if (activateDoor.switchPressed == true) {
            light1.color = Color.green;
            light2.color = Color.green;
        }
	}
}
