using UnityEngine;
using System.Collections;

public class fondoscript : MonoBehaviour {
	
	public Vector3 velocidad;
	public Vector3 distanciaobs;
	// Use this for initialization






	//public SpriteRenderer tubosss;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
			MovObsataculos ();


	}

	void MovObsataculos(){

		this.transform.position = this.transform.position + (velocidad * Time.deltaTime);
		//if(tubosss.isVisible==true){


		if (this.transform.position.x <= -2.38f) {
			Vector3 posicionTemp = this.transform.position + distanciaobs;

			posicionTemp.y = Random.Range (2.51f, 9.19f);
			this.transform.position = posicionTemp;


		}
	}
}
