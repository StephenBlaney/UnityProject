﻿using UnityEngine;
using System.Collections;



public class ButtonsComplete : MonoBehaviour  {
	
	
	public void BUTTON_LOAD_SCENE_WELCOME(){
		Application.LoadLevel("Level_0");
	}
	
	public void BUTTON_LOAD_SCENE_LEVEL1_PLAYING(){
		Application.LoadLevel("Level_two");
	}
}

