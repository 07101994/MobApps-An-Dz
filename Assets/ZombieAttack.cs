using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour {


	public Transform mytarget;
	public GameObject zombie;


	private float speed = 0.5f;


	//public float health = 100f;

	// Use this for initialization
	void Start () {

		//zombie = GameObject.FindWithTag ("enemies");
		//mytarget = GameObject.FindWithTag ("warrior");
		
	}
	
	// Update is called once per frame
	void Update () {


		//transform.position = Vector3.MoveTowards(transform.position, target.position, step);
		transform.position = Vector3.MoveTowards(transform.position, mytarget.position, Time.deltaTime * speed);

	 	this.GetComponent<Animation> ().Play ();

	

		if (transform.position == mytarget.position) {

			this.GetComponent<Animation> ().Stop ();


			Destroy(gameObject);
		}
		
	}
}



