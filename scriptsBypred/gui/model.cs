using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class model : MonoBehaviour {

	public Animation anim;
	public List<string> mod;
	public GameObject player;


	// Use this for initialization
	void Start () {
		//anim.wrapMode = WrapMode.Loop;
		mod.Add("jump");
		mod.Add ("loop_idle");
		mod.Add ("loop_run_funny");

		anim = GetComponent<Animation> ();
	}

	void Update () {
		anim.CrossFade ("loop_idle");
		if (PlayerPrefs.GetFloat("velo") > 1) {
			anim.Play("jump");
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			anim.CrossFade("loop_run_funny" , 1);
		}
	}
}
