using UnityEngine;
using System.Collections;

public class witcherMonster : MonoBehaviour {
	public wip_move player;
	
	public float speedW = 2f;
	public Vector3 moveC;
	
	public float moveTime;
	public float slow;
	
	public bool moveEn = false;
	public wip_move moveable;
	
	
	public float high = 200f;
	
	void OnTriggerEnter(Collider col){
		if (col.gameObject.layer == 8 || col.gameObject.layer == 11) {
			Destroy(col.gameObject , 0.4f);
		}
		if (col.gameObject.layer == 9) {
			Destroy(col.gameObject , 25f);
		}
		if (col.gameObject.layer == 13) {
			moveTime = 3f;
			Destroy(col.gameObject , 0.1f);
		}
		if (col.gameObject.layer == 14) {
			player.enDie = true;
			player.Death();
			moveTime = 3f;
		}
	}
	void Awake(){
		moveC = new Vector3(0,speedW,0);
	}
	
	
	// Update is called once per frame
	void Update () {
		float mul = 1f;
		//rigidbody.AddForce (transform.TransformDirection (Vector3.up) * 9.8f);
		//transform.TransformDirection (Vector3.up * 100f);
		
		if (Input.GetKey (KeyCode.Space) && moveable.enMove == true)
			moveEn = true;
		
		
		moveTime += Time.deltaTime;
		if (moveTime > 5f && moveEn == true) {
			rigidbody.velocity = moveC;
			slow = 0;
		} 
		else {
			rigidbody.velocity = new Vector3(0,slow,0);
		}
		
		if (player.transform.position.y > high) {
			speedW += 1 * mul;
			moveC = new Vector3(0,speedW,0);
			high += 150*mul;
			mul += 1;
		}
		
		if (player.transform.position.y < transform.position.y) {
			player.gameObject.rigidbody.AddForce(Vector3.up * 200 * 8);
		}
		
	}
}
