using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour {
	private Transform TransformThis;
	private Rigidbody rigiThis;
	public float moveSpeed=5f;
	public float rotateSpeed=2f;
	public float rotateForce=100f;
	// Use this for initialization
	void Start () {
		TransformThis = this.GetComponent<Transform>();
		rigiThis = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	    
		float v = Input.GetAxis("Vertical");

		float h = Input.GetAxis("Horizontal");
		//Æ½ÒÆ
		TransformThis.Translate(new Vector3(0,0,1)*Time.deltaTime* moveSpeed* v);

		TransformThis.Rotate (new Vector3(0,1,0),h*rotateSpeed);

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			rigiThis.AddForce (new Vector3(0,1,0)* rotateForce);
		}
	}
}

