using UnityEngine;
using System.Collections;

public class select : MonoBehaviour {
	public GUIStyle org;
	public GUIText ori;
	/*public GameObject p1;
	private GameObject charac;*/

	public static int sel;

	// Use this for initialization
	void Start () {
		//Object play = Instantiate (p1, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnGUI(){
		if (GUI.Button (new Rect (50, 50, 200, 200),"org")) {
			sel = 1;
			Application.LoadLevel("sence");
		}
		if (GUI.Button (new Rect (300, 150, 200, 200),"wiz")) {
			sel = 2;
			Application.LoadLevel("sence");
		}
	}
}
