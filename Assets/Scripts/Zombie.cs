/* Script for Zombie game object.
 * Authors: Lloyd Dzokoto, Aleksandr Anfilov
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Zombie:MonoBehaviour {
  public Transform Spartan;     //Spartan King object
  public GameObject zombie;     //Zombie object
  public float speed;
  public float health = 100f;  //Zombie moving speed and health
  public float attackRange;            // at this range zombie will stop moving and begin attacks
  private Animation anim;       //Zombie object's animation

  // Use this for initialization
  void Start() {
    speed = 0.02f;
    attackRange = 0.05f;
    anim = GetComponent<Animation>();
    //TODO: start moving only if the marker has been seen
    anim.Play();  //animate zombie walking
		  //zombie = GameObject.FindWithTag ("enemies");
  }

  // Update is called once per frame
  void Update() {
    zombieMove();
    //if (health <= 0.0f) {
    //  Debug.Log("DEAD" + health);
    //  // zombie has been killed.
    //  Destroy(zombie);
    //  return;
    //}
    //else {
    //  Debug.Log("move;");
    //  zombieMove();
    //}
  }

  public void zombieMove() {
    float dist = Vector3.Distance(transform.position, Spartan.position);
    //Debug.Log("dist " + dist + "range " + attackRange);
    //if (transform.position != Spartan.position)
      if (dist > attackRange) {
      //makes Zombie move towards the Spartan
      transform.position = Vector3.MoveTowards(transform.position, Spartan.position, Time.deltaTime * speed);
    }
    else {
      //Debug.Log("standing near the Spartan");
      this.GetComponent<Animation>().Stop();
    }
  }

}