using UnityEngine;
using System.Collections;

public class luna : MonoBehaviour {

	public Vector3 velocidad;
	public Vector3 distanciaobs;
	public SpriteRenderer porunga;
	public RectTransform porungaa;

//	public bool puntoss=false;
//	public rockas puntosss;
	// Use this for initialization






	//public SpriteRenderer tubosss;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
//		if (puntoss == true) {
//			porunga.enabled = true;
//		}

		MovObsataculos ();


	}

	void MovObsataculos(){

		this.transform.position = this.transform.position + (velocidad * Time.deltaTime);
		//if(tubosss.isVisible==true){


		if (this.transform.position.x <= 13.1f) {
			Vector3 posicionTemp = this.transform.position + distanciaobs;

			posicionTemp.y = Random.Range (17.1f, 10.19f);
			this.transform.position = posicionTemp;


		}
	}
}
