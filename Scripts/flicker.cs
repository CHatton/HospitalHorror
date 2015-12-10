using UnityEngine;
using System.Collections;

public class flicker : MonoBehaviour {
    public Light light; // pick which light will flicker
   public double flickerTime; // each lamp can have a different flicker time
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
    
        if (Random.value > flickerTime)
        {
            if (light.enabled == true)
            {
                light.enabled = false;
            }
            else {
                light.enabled = true;
            }
            
        }
      

	}
}
