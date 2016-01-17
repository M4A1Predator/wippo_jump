using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class jumpanime : MonoBehaviour {

	public wipmod wipfoot;
	private wip_move player;

	/*void OnCollisionStay(Collision col ){
		if(col.gameObject.layer == 8)	
			wipfoot.jumpable = true;

	}

	void OnCollisionExit(Collision col){
		if (col.gameObject.layer == 8) {
			wipfoot.jumpable = false;
		}
	}*/

	void Update(){
		if (groundjump != null && player.isGround) {
						wipfoot.jumpable = false;
		} 
		else {
			wipfoot.jumpable = true;
		}
	}

	Collider groundjump{
		get {
			RaycastHit hit;
			if(Physics.Raycast(transform.position , Vector3.down , out hit , 1.0f , 8)){
				return hit.collider;
			}
			return null;
		}
	}

}
