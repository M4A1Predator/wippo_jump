using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class wip_score : MonoBehaviour {
	//public GUIText sc;

	public wip_move playermove;

	public GUIText guiScore;

	public Transform player;
	public pickItem showItems;
	public static int score;
	private int max = 10;

	public static bool pause;

	public GUIText[] itemList;

	public Texture2D boost;
	public Texture2D clock;

	public Texture2D pauseTitle;
	public GUIStyle continues;
	public GUIStyle backToMain;

	public pickItem item;
	public GUIText boostN;
	public GUIText clockN;
	public GUIText LifeN;

	/*void Awake(){
		itemList = new GUIText[3];
		foreach (GUIText a in itemList)
						a.text = "item ";
	}*/

	void Start(){
		pause = false;
		playermove.enMove = true;

	}

	// Update is called once per frame
	void Update () {

		if (player.position.y > max) {
			max = (int) player.position.y;
			//Debug.Log (max);
		}
		score = max * 10;

		if (score <= 0)
						score = 0;

		//sc.text = "score : " + score;
		PlayerPrefs.SetInt ("wipScore", score);
		//----score
		guiScore.text = "" + score;

		//-----item

		boostN.text = "x" + item.boost;
		clockN.text = "x" + item.clock;
		LifeN.text = "x" + playermove.life;
		//----

		/*if (showItems.items.Count != 0) {
			for(int a=0;a<showItems.items.Count;a++){
				itemList[a].text = "item : "+showItems.items[a];
			}
		}*/

		if (Input.GetKeyDown (KeyCode.Escape)) {
			//Time.timeScale =  0;
			playermove.enMove = !playermove.enMove;
			pause = !pause;
				if (pause == true) {
					Time.timeScale = 0;

				}
				else {
					Time.timeScale = 1;
				}
		}

	}

	void OnGUI(){
		/*GUILayout.BeginArea (new Rect (10, 10, 150, 100));
		GUILayout.Label ("score " + score);
		//GUILayout.Label ("Bullet " + showItems.b);
		//GUILayout.Label ("Life " + showItems.player.life);
		//GUILayout.Label (""+showItems.items.Count);
		GUILayout.EndArea ();*/

		//GUI.DrawTexture(new Rect(290,545,32,32),boost);
		//GUI.DrawTexture(new Rect(370,547,32,32),clock);
		//GUI.Label (new Rect (50, 50, 70, 70), score.ToString());


		if(pause == true){
			//GUI.Box(new Rect(50,50,1000,500),"", "Box");
			GUI.Box(new Rect(0,0,Screen.width,Screen.height),"");
			GUI.DrawTexture(new Rect(400,150,317,317), pauseTitle);
			
			if(GUI.Button(new Rect(430, 265,260,68), "", continues)){
				pause = !pause;
				playermove.enMove = !playermove.enMove;
				Time.timeScale = 1;
			}
			if(GUI.Button(new Rect(430, 350,260,68), "", backToMain)){
				Time.timeScale = 1;
				Application.LoadLevel("MainMenu");
			}

		}

	}
}
