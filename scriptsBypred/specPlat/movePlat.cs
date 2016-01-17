using UnityEngine;
using System.Collections;

public class movePlat : MonoBehaviour {
	public int rdi;
	void Start(){
		rdi = Random.Range (1, 3);
	}

	void Update () {
		transform.position += (rdi==1?Vector3.left:Vector3.right) * 0.05f;
		if (transform.position.x >= 9.5f) {
			rdi = 1;
			transform.position += Vector3.left * 0.05f;
		}
		else if (transform.position.x <= -5.2f) {
			rdi = 2;
			transform.position += Vector3.right * 0.05f;
		}
	}
}
