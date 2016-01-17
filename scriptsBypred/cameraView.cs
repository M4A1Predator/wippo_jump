using UnityEngine;
using System.Collections;

public class cameraView : MonoBehaviour {
	public Transform target;
	public float trackSpeed = 2f;
	public GameObject player;
	void Update () {
		Vector3 pos = target.position;
		pos.x = 2.0f;
		pos.z = -8.99f;
		transform.position = Vector3.Lerp (transform.position, pos, trackSpeed * Time.deltaTime);

	}
}
