using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawn_plane1 : MonoBehaviour {

	public GameObject plane1;
	public GameObject icy;
	public GameObject slowy;
	public GameObject fallen;
	public GameObject fire;
	public GameObject moveplat;
	//----Case----
	public spawn_item helper;

	public GameObject suit1;
	public GameObject suit2;
	public GameObject suit3;

	//---scene---
	/*public GameObject scene1;
	public GameObject border1;
	public GameObject border2;*/
	private onPlatform reSpawn;
	public GameObject scn;
	//public GameObject fg;

	private Vector3 spawn_point;
	private Vector3 spawn_bg;

	public float timer = 0.0f;
	public float high = 20f;
	public float hs = 20f;
	public float highitem = 60f;


	//-------------
	public int idItem;
	private int dropChance;

	public spawn_item item;
	//-------------

	public Transform player;

	public int min = 16;
	
	//private GameObject clone;
	void spawnplane1(){
		int rny = Random.Range ((int)min+4, (int)min + 5);
		int rnx = Random.Range (-5, 9);
		int planern = Random.Range (0, 3);

		spawn_point = new Vector3 (rnx, rny, -0.4f);
		Object tempspawn = Instantiate (plane1, spawn_point, Quaternion.identity);

		min = rny;

		genItem (rnx, rny);
		item.genLife (rnx , rny);
		//Destroy (tempspawn, 25f);
	}

	void spawnSpecPlat(){
		int rny = Random.Range ((int)min+4, (int)min + 6);
		int rnx = Random.Range (-5, 9);
		GameObject specPlat = null;
		int spec = Random.Range (1, 5);
		if (spec == 1)
			specPlat = icy;
		if (spec == 2)
			specPlat = slowy;
		if (spec == 3) {
			specPlat = fallen;
		}
		if (spec == 4) 
			specPlat = moveplat;

		Object temp = Instantiate (specPlat, new Vector3 (rnx, rny, -0.4f), Quaternion.identity);
		min = rny;
		genItem (rnx, rny);
	}
	
	void spawnFirePlat(){
		int rny = Random.Range ((int)min+4, (int)min + 6);
		int rnx = Random.Range (-5, 9);
		GameObject specPlat = fire;
		Object temp = Instantiate (specPlat, new Vector3 (rnx, rny, -0.4f), Quaternion.identity);
		min = rny;
		genItem (rnx, rny);
		item.genLife (rnx , rny);

	}

	void spawnFallRandom(){
		for(int i=1;i<=5;i++){
			int rny = Random.Range ((int)min+4, (int)min + 6);
			int rnx = Random.Range (-5, 9);
			GameObject fplat = fallen;
			Object temp = Instantiate (fplat, new Vector3 (rnx, rny, -0.4f), Quaternion.identity);
			min = rny;

			genItem (rnx, rny);

		}
	}

	void suit_1(){
		int rny = Random.Range ((int)min+4, (int)min + 6);
		Object temp = Instantiate (suit1, new Vector3 (1.0f, rny+13, -0.4f), Quaternion.identity);
		min = rny+10;
	}

	void suit_2(){
		int rny = Random.Range ((int)min+4, (int)min + 6);
		Object temp = Instantiate (suit2, new Vector3 (2f, rny+7f, -0.4f), Quaternion.identity);
		Object helpItem = Instantiate (helper.item1 , new Vector3 (3.5f , rny+0.4f  , -0.4f),Quaternion.identity) as GameObject;
		min = rny + 6;
	}
	void suit_3(){
		int rny = Random.Range ((int)min+4, (int)min +4);
		Object temp = Instantiate (suit3, new Vector3 (0f, rny, -0.4f), Quaternion.identity);
		min = rny + 8;
	}


	void genscene(){
		spawn_bg = new Vector3 (2.08f,high,-0.26f );
		Object scenespawn = Instantiate (scn, spawn_bg, Quaternion.identity);
	}

	// Update is called once per frame
	public int case_plat;

	void Start(){
		 
	}

	void Update () {
		float playerpoint = player.transform.position.y;
		if (playerpoint > min-10 && playerpoint < 90) {
			//suit_1();
			spawnplane1();
			//spawnFirePlat();
			//spawnFallRandom();
			//spawnSpecPlat();

		}	
		else if (playerpoint > min-10 && playerpoint > 91 && playerpoint < 190) {
			case_plat = Random.Range(1,6);
			/*if(case_plat == 1){
				suit_1();
				min += 2;
			}
			if(case_plat == 2){
				suit_2();
				min += 2;
			}*/
			if(case_plat == 1){
				spawnSpecPlat();
			}
			if(case_plat == 2)
				spawnFallRandom();
			else
				spawnplane1();
				//suit_3();
		}


		else if (playerpoint > min-10 && playerpoint > 191){
			case_plat = Random.Range(1,8);
			if(case_plat == 1){
				suit_1();
				min += 2;
			}
			if(case_plat == 2){
				suit_2();
				min += 2;
			}
			if(case_plat == 3)
				spawnSpecPlat();
			if(case_plat == 4)
				spawnFirePlat();
			if(case_plat == 5)
				suit_3();
			else
				spawnplane1();
		}

		//---
		if (playerpoint > high) {
			high += 30.412f;
			genscene();
		}
		timer += Time.deltaTime;
	}

	void genItem(int x , int y){
		if (player.transform.position.y > highitem) {
			idItem = Random.Range (1, 7);
			if (idItem == 1) {
				Object temp = Instantiate (helper.item1, new Vector3 (x - 1, y + 2, -0.4f), Quaternion.identity);
			}
			if (idItem == 2) {
				Object temp = Instantiate (helper.item2, new Vector3 (x - 1, y + 2, -0.4f), Quaternion.identity);
			}
			/*if (idItem == 3) {
				Object temp = Instantiate (helper.item3, new Vector3 (x - 1, y + 2, -0.4f), Quaternion.identity);
			}*/
			idItem = 0;
			highitem += 120f;
		}
	}

	
}
