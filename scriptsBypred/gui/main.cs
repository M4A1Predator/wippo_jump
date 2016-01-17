using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {

	public Texture2D menubar;
	public GUIStyle tutor;
	public GUIStyle goplay;
	public GUIStyle goScore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (20, 475, 800, 129) , menubar);
		if(GUI.Button(new Rect(310,689,160,50),"",tutor)){
			Application.LoadLevel("Tutorial");
			
		}
		if (GUI.Button (new Rect (480, 675, 160, 70), "", goplay)) {
			Application.LoadLevel("LoginScene");
		}
		if(GUI.Button(new Rect(653,689,160,50),"",goScore)){
			Application.LoadLevel("Story");
		}

		/*GUI.DrawTexture (new Rect (0, 475, 800, 129) , menubar);
		if(GUI.Button(new Rect(150,541,160,50),"",tutor)){
			
		}
		if (GUI.Button (new Rect (320, 527, 160, 70), "", goplay)) {
			Application.LoadLevel("LoginScene");
		}
		if(GUI.Button(new Rect(493,542,160,50),"",goScore)){
		}*/
	}
}
