using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	private int Score = 0;
	private AudioSource audioSource;
	public AudioClip soundSkull;
	private PlayerDisplay playerDisplay;
	
	public int GetScore(){
		return Score;
	}


	void Start(){

		audioSource = GetComponent<AudioSource> ();
		playerDisplay = GetComponent <PlayerDisplay> ();
		playerDisplay.UpdateDisplay ();
	}


		void OnTriggerEnter(Collider hit){
		if (hit.CompareTag ("Skull")) {

			Destroy(hit.gameObject);
			audioSource.PlayOneShot(soundSkull);
			Score ++;

		}
		playerDisplay.UpdateDisplay ();
	}
}
