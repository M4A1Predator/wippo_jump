using UnityEngine;
using System.Collections;

public class firePlat : MonoBehaviour {
	public wip_move player;
	public float timer;

	void Start(){
		player.gameObject.AddComponent ("player");
	}

	void OnTriggerStay(Collider col){
		if (col.gameObject.name == "player_foot") {
			timer += Time.deltaTime;
			if(timer > 1.01f){
				player.life -= 1;
			}
		}
	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.name == "player_foot") {
			timer = 0;
		}
	}
}
