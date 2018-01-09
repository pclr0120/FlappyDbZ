using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BOTONOSSCRIPT : MonoBehaviour {
	public Guardarscript cargar_puntuacionmax;
	public  BOTONOSSCRIPT boton_puntosss;
	public TextMesh txt_puntajealto;
	// Use this for initialization
	public void boton_reiniciar(){
		//Application.LoadLevel ("nivel1");
		SceneManager.LoadScene("nivel1");



	}
	public void boton_puntos(){

		int puntitos = cargar_puntuacionmax.puntuacionMaxima;

		txt_puntajealto.text = puntitos.ToString();

	}
	public void boton_compartir(){

	}

}
