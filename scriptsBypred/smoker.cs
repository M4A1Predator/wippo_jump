using UnityEngine;
using System.Collections;

public class smoker : MonoBehaviour {

	public GameObject witch;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = witch.transform.position;
	}
}
