using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	void Update () {
		float distance;
		if(Input.GetKey (KeyCode.W)){
			transform.Translate(0f, 0f, 5f * Time.deltaTime);
		}
		if(Input.GetKey (KeyCode.A)){
		transform.Translate(-5f* Time.deltaTime, 0f, 0f);
				//transform.Rotate(Vector3.left * 5 * Time.deltaTime);
		}
		if(Input.GetKey (KeyCode.S)){
			transform.Translate(0f, 0f, -5* Time.deltaTime);
		}
		if(Input.GetKey (KeyCode.D)){
			
			//transform.Rotate(Vector3.right * 5 * Time.deltaTime);
			transform.Translate(5f* Time.deltaTime, 0f, 0f);
		}
		if(Input.GetKey (KeyCode.Space)){

			transform.Translate(0f,  5* Time.deltaTime, 0f);

		}
		if (Input.GetKey (KeyCode.F)){
			transform.Translate (0f, -5 * Time.deltaTime, 0f);
		}	
	}
}
