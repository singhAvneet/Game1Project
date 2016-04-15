using UnityEngine;
using System.Collections;

public class Level3Controller : MonoBehaviour {

	//PRIVATE VARIABLES
	private WarCryGameController _warCryGameController;

	//PUBLIC VARIABLES
	public GameObject miniEnemys;
	public BossEnemyController bossEnemy;

	// Use this for initialization
	void Start () {
		this._initiallizeObjects ();
	}
	
	// Update is called once per frame
	void Update () {

		if (this._warCryGameController.BkgRestCount == 3) {
			this._warCryGameController.BkgRestCount += 1;
			//Instantiate Boss Enemy
			Instantiate(this.bossEnemy.gameObject);
			//this.miniEnemys.gameObject.SetActive (false);
		}

		//Check for booEnemyLife and instantiate miniEnemy

		
	}

	//PRIVATE METHODS
	private void _initiallizeObjects(){
		
		this._warCryGameController = GameObject.Find ("WarCryGameContoller").GetComponent<WarCryGameController> ();

		for (int i = 0; i < 2; i++) {
			Instantiate (this.miniEnemys);
		}
	}
		
}
