using UnityEngine;
using System.Collections;

public class forceplayer : MonoBehaviour {
	public Vector3 pos;
	// Use this for initialization
	void Start () {
		transform.Translate (1.5f, 2, -0.4f);
	}
	
	// Update is called once per frame
	void Update () {
		pos = transform.position;
		pos.z = -0.4f;
		transform.position = pos;
		Quaternion ros = transform.rotation;
		ros.z = 0;
		transform.rotation = ros;

		Vector3 vel = rigidbody.velocity;
		/*if(vel.y <= -1 || vel.y >=1){
			vel.y *= 2;
		}*/
	}
}
