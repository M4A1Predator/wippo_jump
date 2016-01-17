using UnityEngine;
using System.Collections;

public class raycast : MonoBehaviour {
	//public RaycastHit hit;

	public GameObject player;
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast (transform.position, -Vector3.up, out hit, 1.0f , 8)) {

		}
	}
	

}