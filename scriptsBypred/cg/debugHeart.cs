using UnityEngine;
using System.Collections;

public class debugHeart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion ros = transform.rotation;
		ros.y = 90;
	}
}
