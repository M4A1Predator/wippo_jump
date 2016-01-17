using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {
	/*public float pushMove;
	public float pushJump;*/
	private select pp;
	public wip_move player;
	public wip_score sPlayer;

	public GameObject playerObj;
	public RaycastHit hit;

	public Vector3 goDown;

	public bool onG;

	

	void Start(){
		player.pushMove = player.defMove;
		player.pushJump = player.defJump;

		player.life = 1;
		Time.timeScale = 1;
		//Object play = Instantiate (player.gameObject, new Vector3 (1.5f, 8.8f, -0.4f), Quaternion.identity);


	}
	
	// Update is called once per frame
	void Update () {
		onG = player.isGround;
		if (player.enMove == true) {

						/*Vector3 posplayer = playerObj.transform.position;
		player.transform.position.z = -0.4f;*/

				if (Input.GetKey (KeyCode.LeftArrow) && playerObj.transform.position.x > -6.9)
						player.moveHorizontal ("left");
				if (Input.GetKey (KeyCode.RightArrow) && playerObj.transform.position.x < 11.01)
						player.moveHorizontal ("right");

						//if (Input.GetKey (KeyCode.Space))
				if (Input.GetButton ("Jump") && player.enJump < 0.166f && player.jumpUp) {
					
						player.Jump ();

						player.enJump += Time.deltaTime;
						if (player.enJump > 0.166f) {
							player.jumpUp = false;
						}
				}

				if (Input.GetButtonUp ("Jump")) {
					player.jumpUp = true;
				}

				if (playerObj.rigidbody.velocity.y < 1) {
					player.enJump = 0;
				}
				if (playerObj.rigidbody.velocity.y > 0) {
					playerObj.collider.isTrigger = true;
				}

				if ((playerObj.rigidbody.velocity.y < 0) || player.transform.position.x < -7.1f || player.transform.position.x > 11.1f) {
					playerObj.collider.isTrigger = false;
				}
				playerObj.rigidbody.AddForce(Vector3.down * 1f);
						//Debug.Log (playerObj.rigidbody.velocity.y);
						/*if (player.life <= 0) {
			Application.LoadLevel("EndGame");
		}*/
			if(!player.isGround){
				playerObj.rigidbody.AddForce(Vector3.down * 10f);
				Debug.Log("Deop");
			}
		}

		PlayerPrefs.SetFloat ("velo", playerObj.rigidbody.velocity.y);

	}
}
