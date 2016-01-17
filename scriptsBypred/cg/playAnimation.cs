using UnityEngine;
using System.Collections;

public class playAnimation : MonoBehaviour {

	private Animation anim;
	// Use this for initialization
	void Start () {
		anim = GetComponentInChildren<Animation> ();
		anim ["loop_idle"].speed = 1.5f;
	}
	
	// Update is called once per frame
	void Update () {
		if(!anim.isPlaying)	
			anim.CrossFade ("loop_idle");

		if (Input.GetKeyDown (KeyCode.Z)) {
			StartCoroutine(waitNim(5));
		}
	}


	IEnumerator waitNim(float wtime){
		anim.Stop("loop_idle");
		anim.CrossFade("kick_jump_right");

		yield return new WaitForSeconds (5);
	}
}
