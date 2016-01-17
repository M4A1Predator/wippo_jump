using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class wip_move : MonoBehaviour {
	private LayerMask mask = 1 << 8;
	//bool isGrounded = false;

	public GameObject wipo;
	public float pushMove = 20f;
	public float pushJump = 90f;

	public float defMove;
	public float defJump;

	public float enJump;
	public bool jumpUp = true;

	//---
	public int life;

	public bool enMove;

	public bool enDie;

		


	public void moveHorizontal(string side){

		rigidbody.AddForce(((side == "left")?Vector3.left:Vector3.right)*(pushMove)); //- Time.smoothDeltaTime));
	}

	public void Jump(){
		if (!isGround) return;

		rigidbody.AddForce (Vector3.up * pushJump);
		wipo.collider.isTrigger = true;

		/*Vector3 posplayer = wipo.transform.position;
		posplayer.z = -0.4f;*/
	}

    public bool isGround{
		get {
				return GroundRay != null;
			}
	}
	Collider GroundRay{
		get {
			RaycastHit hit;
			if(Physics.Raycast(transform.position , Vector3.down , out hit , 1.0f , mask))
			   return hit.collider;
			return null;
		}
	}

	public void Death(){
		if (enDie = true) {
			rigidbody.AddForce (Vector3.up * 200 * 8);
			if(life > 0)
				life -= 1;
			enDie = false;
		}


	}

}
