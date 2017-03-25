using UnityEngine;
using System.Collections;

public class JumpScare : MonoBehaviour {

	public GameObject scarything;
	public AudioClip SoundJumpScare;
	private AudioSource audioSource;


	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	

	void OnTriggerEnter(Collider hit){
		if (hit.CompareTag("Player")) {
			scarything.GetComponent<MeshRenderer>().enabled =true; 
			audioSource.PlayOneShot(SoundJumpScare);
			Object.Destroy(scarything , 2.0f);
		}
	
	}
}


	
		
	




