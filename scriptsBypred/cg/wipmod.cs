using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class wipmod : MonoBehaviour {

	public GameObject player;
	//wip_move playorg;
	public wip_move play = null;
	private Animation anim;

	public bool jumpable;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("player2");
	
		anim = GetComponentInChildren<Animation> ();
		anim ["idle"].speed = 2.0f;
		anim ["run"].wrapMode = WrapMode.Loop;
		anim ["jumping"].wrapMode = WrapMode.PingPong;
		anim ["bjump"].wrapMode = WrapMode.PingPong;

		jumpable = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!anim.isPlaying) {
			anim.CrossFade("idle");
		}

		//if (Input.GetKey (KeyCode.Space) && player.rigidbody.velocity.y > -0.01f) {
		if (!play.isGround && player.rigidbody.velocity.y > 0.2f) {
			anim.CrossFade ("bjump");
		}


		if ((Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.RightArrow)) && play.isGround) {
			anim.CrossFade("run");
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow) && !wip_score.pause && !(play.life <=0) ) {
			transform.Rotate(Vector3.up,90,Space.World);
		} 
		if (Input.GetKeyUp (KeyCode.LeftArrow) && !wip_score.pause && !(play.life <=0)) {
			anim.Stop("run");
			transform.Rotate(Vector3.up,270,Space.World);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow) && !wip_score.pause && !(play.life <=0)) {
			transform.Rotate(Vector3.down,90,Space.World);
		}
		if (Input.GetKeyUp (KeyCode.RightArrow) && !wip_score.pause && !(play.life <=0)) {
			anim.Stop("run");
			transform.Rotate(Vector3.down,270,Space.World);
		}

		if (wip_score.pause) {
			Quaternion rot = transform.rotation;
			rot.y = 180;
			transform.rotation = rot;
		}

		if (player.rigidbody.velocity.y < -0.2f && !play.isGround) {
			anim.CrossFade ("jumping");
		} 
		else {
			anim.Stop("jumping");
		}

		Debug.Log (play.rigidbody.velocity.y);

		Quaternion ros = transform.rotation;
		ros.z = 0;
		ros.x = 0;
		transform.rotation = ros;

	}

}
