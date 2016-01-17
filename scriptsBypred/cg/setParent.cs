using UnityEngine;
using System.Collections;

public class setParent : MonoBehaviour {

	public GameObject model1;
	public GameObject model2;
	public GameObject model3;
	public GameObject model4;
	public GameObject model5;
	public GameObject model6;
	public GameObject model7;
	public GameObject model8;
	public GameObject model9;
	public GameObject model10;
	public GameObject model11;
	//public GameObject model12;
	private GameObject player;
	public wip_move play;

	private GameObject modelwip = null;

	private Vector3 playerpos;
	private int selection;
	Quaternion side;

	// Use this for initialization
	void Start () {
		//selection = select.sel;
		//PlayerPrefs.SetInt ("SelectWipo" , 3);
		selection = PlayerPrefs.GetInt ("SelectWipo");
		if (selection == 0)
			modelwip = model2;
		if (selection == 2)
			modelwip = model2;
		if (selection == 3)
			modelwip = model3;
		if (selection == 4)
			modelwip = model4;
		if (selection == 5)
			modelwip = model5;
		if (selection == 6)
			modelwip = model6;
		if (selection == 7)
			modelwip = model7;
		if (selection == 8)
			modelwip = model8;
		if (selection == 9)
			modelwip = model9;
		if (selection == 10)
			modelwip = model10;
		if (selection == 11)
			modelwip = model11;
		if (selection == 12)
			modelwip = model1;

		//----
		player = Instantiate (modelwip, new Vector3(transform.position.x,transform.position.y - 0.35f,-0.4f), transform.rotation) as GameObject ;
		player.transform.parent = transform;

		side = player.transform.rotation;
		side.y = 0;
		//playerpos = player.transform.position;
	}

	// Update is called once per frame
	void Update () {
		//player.transform.position = transform.position;
		playerpos = player.transform.position;
		playerpos.y = transform.position.y - 0.5f;

		if (play.life <= 0) {
			player.SetActive(false);
		}
						

	}
}
