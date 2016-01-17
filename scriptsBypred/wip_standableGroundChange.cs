using UnityEngine;
using System.Collections;

public class wip_standableGroundChange : MonoBehaviour {
	public wip_groundThrougher headClearer;

	void OnTriggerStay(Collider col){
		if (col.gameObject.layer != 8)
			return;
		if (!isPlayerUp(col.transform)) {
			col.isTrigger = false; //true = not collide
		}
	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.layer != 8)
			return;
		if(isPlayerUp(col.transform))
		   headClearer.resumeOnOut.Add(col);
	}
	bool isPlayerUp(Transform ground){
		return transform.position.y > ground.position.y;
	}
}