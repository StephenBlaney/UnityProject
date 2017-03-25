using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public Player player;

	private CountdownTimer countDownTimer; 
	private int totalSecounds = 250;

	// Use this for initialization
	void Start () {
		countDownTimer = GetComponent <CountdownTimer> ();
		countDownTimer.ResetTimer (totalSecounds);
	}
	
	// Update is called once per frame
	void Update () {
		string msg = " TIME LEFT!!!! " + countDownTimer.GetSecondsRemaining();
		print (msg);

		CheckGameOver ();

	}

	private void CheckGameOver(){
		if(countDownTimer.GetSecondsRemaining()<0){
			int score = player.GetScore();
			PlayerPrefs.SetInt("Score",score);
			Application.LoadLevel(3);
	}
		
  }

}


