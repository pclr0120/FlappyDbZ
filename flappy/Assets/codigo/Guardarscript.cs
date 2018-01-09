using UnityEngine;
using System.Collections;
using System;// serializar
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class Guardarscript : MonoBehaviour {
	public int puntuacionMaxima = 0;
	//public string nombreruta;
	public int record;
	private string rutaArchivo;
	// Use this for initialization
	void Start () {
		rutaArchivo = Application.persistentDataPath + "/datos.dat";
		Cargar ();

	}
	
	// Update is called once per frame
	void Update () {


		//Debug.Log (Application.persistentDataPath);
	}
	void Guardar(){

		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(rutaArchivo);

		DatosAGuardar datos = new DatosAGuardar();
		datos.puntuacionMaxima = puntuacionMaxima;

		bf.Serialize(file, datos);

		file.Close();


	}

	void Cargar(){
		if(File.Exists(rutaArchivo)){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(rutaArchivo, FileMode.Open);

			DatosAGuardar datos = (DatosAGuardar) bf.Deserialize(file);

			puntuacionMaxima = datos.puntuacionMaxima;

			file.Close();
		}else{
			puntuacionMaxima = 0;
		}
	}

	public void puntuacionmaxima_guadar(){
		
		if (puntuacionMaxima< record) {
			
			Debug.Log ("puntuacion maxima superada" + puntuacionMaxima + " actual" + record);

			puntuacionMaxima = record;
			
		
//			Debug.Log ("antede guardar-----" + puntuacionMaxima);
	
			Guardar ();

		} else {
			
//			Debug.Log ("no  superada" + puntuacionMaxima + " actual" + record);
//			Debug.Log ("--------------" + puntuacionMaxima);

		}
	}


}
[Serializable]
class DatosAGuardar{
	public int puntuacionMaxima;
//	public Datosguardar(int puntuacionmaxima)
//	{
//		this.puntuacionmaxima = puntuacionmaxima;
//	}

} 
