using UnityEngine;
using System.Collections;
public class wip_groundChanger : MonoBehaviour {
	public wip_move player;
	public bool onTriggerOnHit = false;
	bool IsPlayerUp(Collider col){
		Vector3 targetUp = col.transform.TransformDirection (Vector3.up);
		if (targetUp.y > player.transform.TransformDirection (Vector3.down).y)
			return true;
		return false;
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.layer == 8)
			col.isTrigger = onTriggerOnHit;
	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.layer == 8)
			col.isTrigger = true;
	}
}