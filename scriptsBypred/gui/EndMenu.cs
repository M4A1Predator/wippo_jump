using UnityEngine;
using System.Collections;

public class EndMenu : MonoBehaviour {

	public Texture2D box;
	public wip_move player;
	public GUIStyle gotomain;
	public GUIStyle restart;
	public GUIStyle share;
	public GUIText scoreEnd;
	public GUIStyle sce;

	public InteractiveConsole1 FBshare;

	public Texture2D diePic;

	/*void OnMouseEnter(){
		renderer.material.color = Color.black;
	}

	void OnMouseExit(){
		renderer.material.color = Color.white;
	}

	void OnMouseDown(){
		Application.LoadLevel ("sence");
	}*/
	void Start(){
		FBshare.enabled = false;
		FBshare.GetComponent<InteractiveConsole1>();
		PlayerPrefs.SetInt ("wipScore", 0);
	}
	void Update(){
	}

	void OnGUI(){
		if (player.life <= 0) {
			GUI.contentColor = Color.white;
			Time.timeScale = 0;
			GUI.Box(new Rect(0,0,Screen.width,Screen.height),"");
			GUI.DrawTexture (new Rect (340, 30, 468, 609), box);
			GUI.DrawTexture (new Rect (240-10,91,345,152) , diePic);
			GUI.Label(new Rect(510, 255, 300, 500),PlayerPrefs.GetInt("wipScore").ToString(),sce);

			if(GUI.Button(new Rect(400,410,340,71) , "", restart)){
				Application.LoadLevel("sence");
			}
			if(GUI.Button(new Rect(400,500,340,71), "", gotomain)){
				Application.LoadLevel("MainMenu");
			}
			/*if(GUI.Button(new Rect(216-10,480,397,71), "", share)){
				FBshare.enabled = true;
				FBshare.enShare = true;
				//Application.LoadLevel("Shared");
			}*/
		}
	}
}
