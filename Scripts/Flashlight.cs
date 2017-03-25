using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

	Light flashlight;
	bool on = false;
	
	void Start()
	{
		flashlight = GetComponentInChildren<Light>();
	}
	
	void Update()
	{
		if(on)
			flashlight.GetComponent<Light>().enabled = true;
		else if(!on)
			flashlight.GetComponent<Light>().enabled = false;
		if(Input.GetKeyDown(KeyCode.Mouse1))
			on = !on;
	}
}
