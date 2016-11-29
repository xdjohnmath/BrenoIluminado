using UnityEngine;
using System.Collections;

public class Moviment : MonoBehaviour {

	public float vel;
	public Vector3 [] newPosition = new Vector3 [3];

	public ParticleSystem fora;
	public ParticleSystem dentro;


	
	void Update () {
	
		float v = Input.GetAxis ("Vertical") * Time.deltaTime * vel;
		float h = Input.GetAxis ("Horizontal") * Time.deltaTime * vel;

		transform.Translate (0, 0, v);
		transform.Rotate (0, h * 40, 0);


		for (int i = 0; i < 3; i++) {
			i = Random.Range (0, 3);

			if (transform.position.y < -7) {
				transform.position = newPosition [i];
				transform.rotation = Quaternion.Euler  (0, 0, 0);

			}
		}
	}
}
