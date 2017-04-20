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
  private float speed, health,  //Zombie moving speed and health
	  stopRange;            // at this range zombie will stop moving and begin attacks
  private Animation anim;       //Zombie object's animation

  // Use this for initialization
  void Start() {
    health = 100f;
    speed = 0.02f;
    stopRange = 1f;
    anim = GetComponent<Animation>();
    //TODO: start moving only if the marker has been seen
    anim.Play();  //animate zombie walking
		  //zombie = GameObject.FindWithTag ("enemies");
  }

  // Update is called once per frame
  void Update() {
    if (health <= 0) {
      // zombie has been killed.
      Destroy(zombie);
      return;
    }
    else {
      zombieMove();
    }
  }

  private void zombieMove() {
    if (transform.position != Spartan.position) {
      //move in a straight line towards the Spartan
      transform.position = Vector3.MoveTowards(transform.position, Spartan.position, Time.deltaTime * speed);
    }
    else {
      //  Debug.Log("standing near the Spartan");
      this.GetComponent<Animation>().Stop();
    }
  }
}