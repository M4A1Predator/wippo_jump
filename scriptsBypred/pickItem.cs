using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class pickItem : MonoBehaviour {
	
	//public controller stat;
	public wip_move player;
	public witcherMonster mon;
	public float timer = 0;
	public int currentItem = 0;
	
	public GameObject bullet;
	
	public List<int> items;
	
	public int b = 1;
	public float shootDeley;
	
	//----
	public float deley;
	//-----new system
	public int boost;
	public int clock;


	void jumper(){
		player.pushJump *= 1.7f;
		timer = 0;

	}
	void slowWitch(){
		mon.slow = 0.2f;
		mon.moveTime = 2.5f;
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.layer == 11) {
			if (col.gameObject.name == "jumper(Clone)" || (col.gameObject.name == "jumper")) {
				Destroy (col.gameObject);
				if(boost < 3 ){
					boost += 1; 
				}
			}
			if (col.gameObject.name == "escw(Clone)" || (col.gameObject.name == "escw")) {
				Destroy (col.gameObject);
				if(clock < 3 ){
					clock += 1; 
				}
			}
		}
		if (col.gameObject.layer == 15) {
			if (col.gameObject.name == "life(Clone)" || col.gameObject.name == "life"){
				Destroy (col.gameObject);
				if(player.life < 3){
					player.life += 1;
				}
			}
		}
	}
	
	//---
	void Update(){
		
		timer += Time.deltaTime;
		if (timer > 5) {
			player.pushJump = player.defJump;
		}	
		deley += Time.deltaTime;

		if (Input.GetKey (KeyCode.Z)) {
			if(boost > 0 && deley > 3){
				jumper();
				--boost;
				deley = 0;
			}
		}
		if (Input.GetKey (KeyCode.X)) {
			if(clock > 0 && deley > 3){
				slowWitch();
				--clock;
				deley = 0;
			}
		}
		
		
	}
}
