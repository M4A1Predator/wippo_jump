using UnityEngine;
using System.Collections;

public class main2 : MonoBehaviour {

	public Texture2D menubar;
	public GUIStyle guest;
	public GUIStyle back;
	//public GUIStyle goScore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (380, 300, 348, 246) , menubar);
		if(GUI.Button(new Rect(417,340,276,74),"",guest)){
			Application.LoadLevel("CharacterGuest");
		}
		if (GUI.Button (new Rect (417, 442, 276,74), "", back)) {
			Application.LoadLevel("MainMenu");
		}
		//if(GUI.Button(new Rect(653,690,160,50),"",goScore)){
		//}

		/*GUI.DrawTexture (new Rect (0, 475, 800, 129) , menubar);
		if(GUI.Button(new Rect(150,541,160,50),"",guest)){
			
		}
		if (GUI.Button (new Rect (320, 527, 160, 70), "", back)) {
			Application.LoadLevel("LoginScene");
		}
		if(GUI.Button(new Rect(493,542,160,50),"",goScore)){
		}*/
	}
}
