/* Script for the Spartan game object.
 * Author: Lloyd Dzokoto
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spartan:MonoBehaviour {
  public GameObject spartan, zombie;  //renamed Target to zombie
  private Vector3 normalizeDirection;
  private float distance, maxDistance, damage;
  public float health;
  private GameObject[] enemies;

  void Start() {
    maxDistance = 1.0f;
    damage = 100;
    health = 100;

    //zombie = GameObject.FindGameObjectsWithTag ("enemies");
    zombie = GameObject.Find ("Zombie1");
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
    //find target with tag
    zombie = ClosestZombie();

    //find distance to target
    //Todo: execute this only if a Zombie object wasn't destroyed
    distance = Vector3.Distance(transform.position, zombie.transform.position);
    //Debug.Log (distance);

    //if within damaging range
    if (distance < maxDistance) {

      //send message to targets script
      zombie.SendMessage("ApplyDamage", damage);	//Aleksandr: SendMessage ApplyDamage has no receiver!
      spartan.GetComponent<Animation>().Play("attack");
    }
  }
}