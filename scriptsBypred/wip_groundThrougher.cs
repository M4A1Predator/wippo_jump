using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class wip_groundThrougher : MonoBehaviour {
	void OnTriggerEnter(Collider col){
		if (col.gameObject.layer == 8) {
			col.isTrigger = true;
		}
		if (col.gameObject.layer == 9)
			col.isTrigger = false;
	}


	public List<Collider> resumeOnOut;

	void OnTriggerExit(Collider col){
		if (resumeOnOut.Count != 0)
						return;
		foreach(Collider resume in resumeOnOut){
			resume.isTrigger = false;
		}
		resumeOnOut.Clear ();
	}
}
	