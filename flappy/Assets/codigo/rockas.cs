using UnityEngine;
using System.Collections;



public class rockas : MonoBehaviour {
	public Vector3 velocidad;
	public Vector3 distanciaobs;
	// Use this for initialization
	public TextMesh puntaje;
	private bool aumentarpuntos = true;
	public rockas t1;
	public rockas t2;
	public bool juegoiniciado;

	public AudioClip sonidoPunto;
	public int puntos;
	public flappyscript juego_terminado;
	public Guardarscript record;
	public luna porunga;
	//public flappyscript guardar_dato_max;
//	public Guardarscript gdp;



	//public SpriteRenderer tubosss;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (puntos == 5) {

			t1.velocidad = new Vector3 (-3.8f, 0, 0);
			t2.velocidad = new Vector3 (-3.8f, 0, 0);


		} else if (puntos >=15  && puntos <= 19) {
			velocidad = new Vector3 (-3.85f, 0, 0);
			porunga.porunga.gameObject.SetActive (true);
		
}
		if (juegoiniciado == true && juego_terminado.juego_t ==false) {
				MovObsataculos ();

			}


	}

	void MovObsataculos(){

		this.transform.position = this.transform.position + (velocidad * Time.deltaTime);
		//if(tubosss.isVisible==true){


		if(this.transform.position.x <= -5.96f){
			Vector3 posicionTemp = this.transform.position + distanciaobs;

			posicionTemp.y = Random.Range (0.37f, -1.4f);
			this.transform.position = posicionTemp;
			aumentarpuntos = true;

		}
		if (this.transform.position.x <= -4.10f & aumentarpuntos==true) {
			puntos = int.Parse (puntaje.text)+1;
			puntaje.text = puntos.ToString ();
			aumentarpuntos = false;
			ReproducirSonido (sonidoPunto);

			record.record = puntos;
//			Debug.Log ("puntos" +puntos);
//			if(guardar_dato_max.juego_t ==true){
//				gdp.puntuacionmaxima_guadar ();
//
//			}
		}
	}
	private void ReproducirSonido(AudioClip clipOriginal)
	{
		// Como no es un sonido 3D la posicion no importa
		AudioSource.PlayClipAtPoint(clipOriginal, transform.position);
	}


}



