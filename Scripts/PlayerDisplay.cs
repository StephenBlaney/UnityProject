using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerDisplay : MonoBehaviour {

	private Player player;
	public RawImage rawImageScore;
	public Texture textureScore0;
	public Texture textureScore1;
	public Texture textureScore2;
	public Texture textureScore3;
	public Texture textureScore4;
	public Texture textureScore5;
	public Texture textureScore6;
	public Texture textureScore7;
	public Texture textureScore8;
	public Texture textureScore9;



	void Start(){
		player = GetComponent<Player> ();
	
	}
	public void UpdateDisplay(){
		UpdateCarryingSkullDisplay ();
		UpdateScoreImage ();
	}
	public void UpdateScoreImage(){

		int score = player.GetScore ();
		if (0 == score) {
			rawImageScore.texture=textureScore0;
		}
		if (1 == score) {
			rawImageScore.texture =textureScore1;
		}
		if (2 == score) {
			rawImageScore.texture=textureScore2;
		}
		if (3 == score) {
			rawImageScore.texture =textureScore3;
		}
		if (4 == score) {
			rawImageScore.texture =textureScore4;
		}
		if (5 == score) {
			rawImageScore.texture =textureScore5;
		}
		if (6 == score) {
			rawImageScore.texture =textureScore6;
		}

		if (7 == score) {
			rawImageScore.texture =textureScore7;
		}

		if (8 == score) {
			rawImageScore.texture =textureScore8;
		}

		if (9 == score) {
			rawImageScore.texture =textureScore9;
		}
	}

	public void UpdateCarryingSkullDisplay(){

		int score = player.GetScore ();


	}

}

