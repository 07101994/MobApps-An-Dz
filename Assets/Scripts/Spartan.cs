using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spartan:MonoBehaviour {
  public GameObject spartan, Target;
  private Vector3 normalizeDirection;
  private float distance, maxDistance, damage;
  private GameObject[] enemies;

  void Start() {
    maxDistance = 1.0f;
    damage = 100;

    //Target = GameObject.FindGameObjectsWithTag ("enemies");
    //zombie = GameObject.Find ("zombie");

    spartan = GameObject.Find("Spartan");

    //normalizeDirection = (target.position - transform.position).normalized;

    spartan.GetComponent<Animation>().Play("walk");

    //foreach (GameObject attackTarget in enemies) {
    //transform.position = Vector3 (transform.position, this.transform.position, speed * Time.deltaTime);
    //attackTarget.GetComponent<Animation> ().Play ();
    //}
  }

  GameObject ClosestZombie() {
    float closestDistanceSqr = Mathf.Infinity;
    GameObject bestTarget = null;
    enemies = GameObject.FindGameObjectsWithTag("enemies");
    foreach (GameObject objTarget in enemies) {
      //float d = Vector2.Distance (this.transform.position, obj.transform.position);
      Vector3 directionToTarget = objTarget.transform.position - this.transform.position;
      float dSqrToTarget = directionToTarget.sqrMagnitude;
      if (bestTarget == null || dSqrToTarget < closestDistanceSqr) {
	closestDistanceSqr = dSqrToTarget;
	bestTarget = objTarget;
      }
    }
    return bestTarget;
  }

  void ApplyDamage(float damage) {
    print(damage);
  }

  void Update() {
    //transform.position += normalizeDirection * speed * Time.deltaTime;

    //zombie.GetComponent<Animation> ().Play ();


    //find target with tag
    Target = ClosestZombie();
    //transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Time.deltaTime * speed);

    //find distance to target
    //Todo: execute this only if a Zombie object wasn't destroyed
    distance = Vector3.Distance(transform.position, Target.transform.position);
    //Debug.Log (distance);

    //if within damaging range
    if (distance < maxDistance) {

      //send message to targets script
      Target.SendMessage("ApplyDamage", damage);
      spartan.GetComponent<Animation>().Play("attack");
    }
  }
}