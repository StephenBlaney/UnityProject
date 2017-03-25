using UnityEngine;
using System.Collections;

public class Level2 : MonoBehaviour {

	public Player player;

	void OnTriggerEnter(Collider hit){
		if (hit.CompareTag ("Player")) {
			int score = player.GetScore();
			PlayerPrefs.SetInt("Score",score);
			Application.LoadLevel(4);

		}
	}
}
