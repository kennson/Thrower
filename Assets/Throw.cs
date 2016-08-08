using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {

	public Transform head;
	public bool holding = false;
	public float speed = 20.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Interact(GameObject ball){
	

		if (holding == false) {
			ball.transform.parent = head;
			holding = true;
		
		} else {
			ball.transform.GetComponent<Rigidbody>().velocity = head.forward * speed;
		}
	}
}
