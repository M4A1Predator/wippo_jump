using UnityEngine;
using System.Collections;

public class spawn_item : MonoBehaviour {
	public GameObject item1;
	public GameObject item2;
	public GameObject item3;
	public GameObject revive;

	public float hf = 150f;
	public GameObject player;

	public float high = 100f;
	public int rni;


	
	/*void genItems(){
		float rnx = Random.Range (-6.5f, 6.5f);
		rni = Random.Range (1, 4);
		//GameObject item = null;
		if(rni == 1) 
			item = item1;
		else if(rni == 2)
			item = item2;
		else if(rni == 3)
			item = item3;
		Object tempItem = Instantiate (item,new Vector3 (rnx, high + 50f, -0.4f), Quaternion.identity);
		//item = null;
	}*/

	public void genLife(int x , int y){

		if (player.transform.position.y > high) {
			rni = Random.Range (1, 4);
			if (rni == 1) {
				Object tempRevive = Instantiate (revive, new Vector3 (x + 1, (float)y + 1.5f, -0.4f), Quaternion.identity); 
			}
			high += Random.Range(135,251);
		}
	}
	// Update is called once per frame
	void Update () {

		/*if (player.transform.position.y > high) {
			genItems();
			high += Random.Range(100f,120f);
		}

		if (player.transform.position.y > hf) {
			genLife();
			hf += Random.Range(200f,350f);
		}*/
	}
}
