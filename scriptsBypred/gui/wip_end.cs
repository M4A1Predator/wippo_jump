using UnityEngine;
using System.Collections;

public class wip_end : MonoBehaviour {
	public int score;

	public GUIText end;

	// Use this for initialization
	void Awake () {
		end.text = "SCORE : " + PlayerPrefs.GetInt("wipScore");
	}


	void Update(){
		//end.text = "SCORE " + PlayerPrefs.GetInt("wipScore");
	}


	// Update is called once per frame
	/*void OnGUI(){
			GUILayout.BeginArea (new Rect (100, 100, 250, 100));
			GUILayout.Label ("Score ");
			GUILayout.EndArea ();
	}*/
}
