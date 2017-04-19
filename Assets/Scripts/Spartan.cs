using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spartan : MonoBehaviour {


	private Vector3 normalizeDirection;
	public GameObject SpartanKing;


	public GameObject Target;

	//public float speed = 0.5f;

	private float distance;
	private float maxDistance = 1.0f;
	private float damage = 100;

	GameObject[] enemies;

	void Start()
	{


		//Target = GameObject.FindGameObjectsWithTag ("enemies");
		//zombie = GameObject.Find ("zombie");

		SpartanKing = GameObject.Find ("SpartanKing");

		//normalizeDirection = (target.position - transform.position).normalized;





		//SpartanKing.GetComponent<Animation> ().Play ("walk");

		//foreach (GameObject attackTarget in enemies) {
			//transform.position = Vector3 (transform.position, this.transform.position, speed * Time.deltaTime);
			//attackTarget.GetComponent<Animation> ().Play ();
		//}


	}


	GameObject ClosestZombie(){



		enemies = GameObject.FindGameObjectsWithTag ("enemies");

		float closestDistanceSqr = Mathf.Infinity;

		GameObject bestTarget = null;

		foreach(GameObject objTarget in enemies){

			//float d = Vector2.Distance (this.transform.position, obj.transform.position);
			Vector3 directionToTarget = objTarget.transform.position - this.transform.position;

			float dSqrToTarget = directionToTarget.sqrMagnitude;

			if(bestTarget == null || dSqrToTarget < closestDistanceSqr) {
				closestDistanceSqr = dSqrToTarget;
				bestTarget = objTarget;
			}

		}

		return bestTarget;
	}


	void ApplyDamage(float damage) {
		print(damage);
	}

	void Update()
	{


		//transform.position += normalizeDirection * speed * Time.deltaTime;

		//zombie.GetComponent<Animation> ().Play ();


		//find target with tag
		Target = ClosestZombie ();

		//transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Time.deltaTime * speed);

		//find distance to target
		//Todo: execute this only if a Zombie object wasn't destroyed
		distance = Vector3.Distance(transform.position, Target.transform.position); 

		//Debug.Log (distance);

		//if within damaging range
		if (distance < maxDistance) {

			//send message to targets script
			Target.SendMessage ("ApplyDamage", damage);  

			SpartanKing.GetComponent<Animation> ().Play ("attack");

		} 

	}



}
