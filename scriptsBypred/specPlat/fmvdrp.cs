using UnityEngine;
using System.Collections;

public class fmvdrp : MonoBehaviour {

	public int rdi;
	
	/*void OnTriggerStay(Collider col){
		if (col.gameObject.name == "player_foot") {
			transform.parent = col.transform;
		}
	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "Player") {
			transform.parent = null;
		}
	}*/
	
	void Start(){
		rdi = Random.Range (1, 3);
	}
	
	void Update () {
		transform.position += (rdi==1?Vector3.left:Vector3.right) * 0.05f;
		if (transform.position.x >= 9.5f) {
			//transform.position = 0;
			rdi = 1;
			transform.position += Vector3.left * 0.05f;
		}
		else if (transform.position.x <= -5.2f) {
			//transform.position = 0;
			rdi = 2;
			transform.position += Vector3.right * 0.05f;
			
		}
		
	}
}