using UnityEngine;
using System.Collections;

public class Lights : MonoBehaviour {


	private float 			timeF;
	private int 			timeI;

	public 	int 			flowTime;

	public 	Light 			luz;
	public	GameObject 	drento, frora;

	void Start () {
		luz.enabled = false;
		drento.SetActive (true);
		frora.SetActive (true);
	}

	void Update () {

		timeF += Time.deltaTime;
		timeI = (int)timeF;

		if (timeI % flowTime == 0) {
			float x = Random.Range (-3.89f,27.85f);
			float z = Random.Range (-4.53f, 12);

			transform.position = new Vector3 (x, 0.5f, z);
		}
	}

	IEnumerator tempo(){
		luz.enabled = true;
		drento.SetActive (false);
		frora.SetActive (false);
		yield return new WaitForSeconds (5f);
		luz.enabled = false;
		drento.SetActive (true);
		frora.SetActive (true);
	}

	void OnTriggerEnter (Collider c) {
		if (c.CompareTag ("Player")){
			StartCoroutine (tempo ());
		}
	}
}
