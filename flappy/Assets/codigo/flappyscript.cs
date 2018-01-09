using UnityEngine;
using System.Collections;

public class flappyscript : MonoBehaviour {
	Vector3 velocidad = Vector3.zero;
	public Vector3 gravedad;
	public Vector3 velocidadAleteo;
	bool aleteo =false;
	public float velocidadMax;
	public rockas t1;
	public rockas t2;
	public flappyscript mono;
	public  bool colis ;
    private Animator ani;
	private bool juego_i;
	public bool juego_t;
	//public bool juego_iniciado;
	public RectTransform menu;
	public detener detenerobs;

	public BOTONOSSCRIPT cargar_puntosmax;
	public Guardarscript maxipuntos;
	public bool toque =false;
	// Use this for initialization
	void Start () {
		ani = this.gameObject.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		int numPresiones = 0;
		//mejora el toque touch
		foreach (Touch toque in Input.touches) {
			if (toque.phase != TouchPhase.Ended && toque.phase != TouchPhase.Canceled)
				numPresiones++;
		}
		//para activar el juego
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)|| Input.GetKeyDown(KeyCode.X)) {
			aleteo = true;
			juego_i = true;
			toque = true;
			t1.juegoiniciado = true;
			t2.juegoiniciado = true;
		//	Debug.Log ("puntos" + t1.puntos + "tubodos puntos " + t2.puntos);

		}
	if (juego_t == true) {
			cargar_puntosmax.boton_puntos ();
			menu.gameObject.SetActive (true);


	}
	}

	void FixedUpdate(){

		if (juego_i) {
			velocidad += gravedad * Time.deltaTime;
			if (aleteo == true) {
				aleteo = false;
				velocidad.y = velocidadAleteo.y;
			}
			transform.position += velocidad * Time.deltaTime;
			float angulo = 0;
			if (velocidad.y >= 0) {
				//Cambiamos el angulo si Y es positivo que mire arriba
				angulo = Mathf.Lerp (0, 25, velocidad.y / velocidadMax);
			} else {
				//Cambiamos el angulo si Y es negativo que mire abajo
				angulo = Mathf.Lerp (0, -75, -velocidad.y / velocidadMax);
			}
			//Rotamos
			transform.rotation = Quaternion.Euler (0, 0, angulo);
		}
	}

	//se activa con cual quier colision 

	void OnCollisionEnter2D (Collision2D colision){


		if((colision.gameObject.name == "obstaculoArriba") || (colision.gameObject.name == "obstaculoAbajo") ||(colision.gameObject.name=="suelo_trunk_1")||( colision.gameObject.name == "suelo_trunk_1")){
			detenerobs.parar ();
			mono.gravedad = new Vector3 (80, 50, 0);
			colis = true;
			t1.juegoiniciado = false;

			juego_t = true;
			ani.SetTrigger ("juegoterminado");
		
			maxipuntos.puntuacionmaxima_guadar ();
			//t1.puntos = t1.puntos + 1;


		}
	}


		
	
}
