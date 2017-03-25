using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {
	
	public GameObject textBox;
	public Text theText;

	public string[] textLines;


	public TextAsset textFile;

	public int currentLine;
	public int endAtLine;

	public CharacterController player;


	
	
	void Start () {

		player = FindObjectOfType<CharacterController> ();
		
		if (textFile != null) {
			
			textLines = (textFile.text.Split('\n'));
			Time.timeScale = 0f;
			
		}

		if (endAtLine == 0) {

			endAtLine = textLines.Length - 1;
			Time.timeScale = 1f;
		}

		
	}

	void Update(){
		theText.text   = textLines[currentLine];
		if (Input.GetKeyDown (KeyCode.Return)) {

			currentLine +=1; 
		}

		if (currentLine > endAtLine) {
			textBox.SetActive(false);
		}
	}
	
	
}

