using UnityEngine;
using System.Collections;

public class onPlatform : MonoBehaviour {

	public wip_move player;
	public float timeFall = 0;
	public float timeFire;

	private spawn_plane1 respawn;

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "fallen" || col.gameObject.name == "fallen(Clone)") {
			timeFall = 0;
		}
	}
	void OnTriggerStay(Collider col){
		if (col.gameObject.name == "icy" || col.gameObject.name == "icy(Clone)") {
			player.pushMove = 46f;
		}
		if (col.gameObject.name == "slow" || col.gameObject.name == "slow(Clone)") {
			player.pushMove = 15f;

		}
		if (col.gameObject.name == "fallen" || col.gameObject.name == "fallen(Clone)") {
			timeFall += Time.deltaTime;
			if(timeFall > 1.0f){
				col.gameObject.AddComponent<Rigidbody> ();
				col.isTrigger = true;
			}
		}
		if (col.gameObject.name == "firePlat" || col.gameObject.name == "firePlat(Clone)" || col.gameObject.name == "fireMv(Clone)" || col.gameObject.name == "fireMv") {
			timeFire += Time.deltaTime;
			player.gameObject.transform.parent = col.transform;
			if(timeFire > 1.5f){
				timeFire = 0;
				player.Death();

			}
		}
		if (col.gameObject.name == "movePlat"  || col.gameObject.name == "movePlat(Clone)") {
			player.gameObject.transform.parent = col.transform;
		}
	}
	
	void OnTriggerExit(Collider col){
		if (col.gameObject.tag != "plat") {
			player.pushMove = player.defMove;
			//player.pushJump = 80f;
		}
		if (col.gameObject.name == "fallen" || col.gameObject.name == "fallen(Clone)") {
			if(timeFall > 0.25f && player.transform.position.y > col.transform.position.y + 2f){
				col.gameObject.AddComponent<Rigidbody> ();
				col.isTrigger = true;
			}
			timeFall = 0;
		}
		if (col.gameObject.name == "firePlat" || col.gameObject.name == "firePlat(Clone)" || col.gameObject.name == "fireMv(Clone)" || col.gameObject.name == "fireMv") {
			timeFire = 0;
			player.gameObject.transform.parent = null;
			player.gameObject.transform.localScale = new Vector3(1,1,1);
		}
		if (col.gameObject.name == "movePlat" || col.gameObject.name == "movePlat(Clone)") {
			player.gameObject.transform.parent = null;
			player.gameObject.transform.localScale = new Vector3(1,1,1);
		}

	}

	void Start(){

	}

	void Update(){
		//Debug.Log (player.rigidbody.velocity.x);
	}

	void ChangeScale(){
		//Transform playerS = player.gameObject.transform;
		//playerS.localScale = 
	}

}
