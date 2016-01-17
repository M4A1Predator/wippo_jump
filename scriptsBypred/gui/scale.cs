using UnityEngine;
using System.Collections;

public class scale : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 scl = transform.localScale;
		scl.x = 1;
		scl.y = 1;
		scl.z = 1;
	}
}
