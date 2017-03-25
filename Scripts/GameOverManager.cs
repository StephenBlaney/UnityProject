using UnityEngine;
using System.Collections;

using UnityEngine.UI;


public class GameOverManager : MonoBehaviour {
	private Text textScore;
	
	void Start () {
	
		textScore = GetComponent<Text> ();

		if (PlayerPrefs.HasKey ("Score")) {
			int score = PlayerPrefs.GetInt("Score");
			string msg ="Your score was: " + score;
			textScore.text = msg;
		}
		else{
			textScore.text="";

		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
