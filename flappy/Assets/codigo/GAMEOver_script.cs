using UnityEngine;
using System.Collections;

public class GAMEOver_script : MonoBehaviour {


	public Vector3 velocidad3;
	public Vector3 distanciaobs3;
	// Use this for initialization
	public flappyscript game_over;
	public GAMEOver_script gm;
	//public SpriteRenderer tubosss;
	void Start () {

	}

	// Update is called once per fragme
	void Update () {
		
			MovObsataculos3 ();
		
	}

	void MovObsataculos3(){


		//if(tubosss.isVisible==true){

 	if (game_over.colis == true) {

			this.transform.position = this.transform.position + (velocidad3 * Time.deltaTime);
			if(this.transform.position.x <= 17.90f){
			gm.velocidad3 = new Vector3 (0,0,0);
			}
		}
	}
}
