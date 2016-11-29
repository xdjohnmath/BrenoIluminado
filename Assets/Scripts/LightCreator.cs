using UnityEngine;
using System.Collections;

public class LightCreator : MonoBehaviour {

	public int lights;
	public GameObject vermelho, azul, verde, amarillo;


	void Start () {
		float x = Random.Range (-3.89f,27.85f);
		float z = Random.Range (-4.53f, 12);

		Vector3 vetin = new Vector3 (x, 0.5f, z);

		for (int i = 0; i < lights; i++) {
			Instantiate (vermelho, vetin, Quaternion.identity);	
		}
		for (int i = 0; i < lights; i++) {
			Instantiate (azul, vetin, Quaternion.identity);	
		}
		for (int i = 0; i < lights; i++) {
			Instantiate (amarillo, vetin, Quaternion.identity);	
		}
		for (int i = 0; i < lights; i++) {
			Instantiate (verde, vetin, Quaternion.identity);	
		}

	}
	

	void Update () {
		
	}
}
