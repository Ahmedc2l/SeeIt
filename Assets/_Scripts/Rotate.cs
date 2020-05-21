using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		//transform.Rotate(0,20*Time.deltaTime,0);
		transform.RotateAround (Vector3.up, 1 * Time.deltaTime);
	}
}