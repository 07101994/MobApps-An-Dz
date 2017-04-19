using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
	public Transform king;
	//Spartan King object
	public GameObject zombie;
	//Zombie object
	private float speed = 0.5f;
	//Zombie moving speed
	private Animation anim;
	//Zombie object's animation
	//private float health = 100f;

	// Use this for initialization
	void Start ()
	{
		anim = this.GetComponent<Animation> ();
		anim.Play ();
		
		//TODO: start moving only if the marker has been seen

		//zombie = GameObject.FindWithTag ("enemies");
		//mytarget = GameObject.FindWithTag ("warrior");
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = Vector3.MoveTowards (transform.position, king.position, Time.deltaTime * speed);	//makes Zombie move towards the King
		if (transform.position == king.position) {
			Debug.Log ("transform.position == king.position");
			this.GetComponent<Animation> ().Stop ();


			//Destroy (gameObject);
		}
		
	}
}



