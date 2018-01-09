using UnityEngine;
using System.Collections;

public class detener : MonoBehaviour {
	public luna lunita;

	public fondoscript nuve1;

	public rockas obstaculosdetener1;
	public rockas obstaculosdetener2;
	public void parar(){
		obstaculosdetener1.velocidad = new Vector3 (0, 0, 0);
		obstaculosdetener2.velocidad = new Vector3 (0, 0, 0);
		lunita.velocidad = new Vector3 (0, 0, 0);

	nuve1.velocidad = new Vector3 (0, 0, 0);
	}
}
