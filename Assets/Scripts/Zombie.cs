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
  public float health;  //Zombie moving speed and health
  public float attackRange;            // at this range zombie will stop moving and begin attacks
  private Animation anim;       //Zombie object's animation

  // Use this for initialization
  void Start() {
    speed = 0.02f;
    attackRange = 0.1f;
    health = 100f;
    anim = GetComponent<Animation>();
    //TODO: start moving only if the marker has been seen
    anim.Play();  //animate zombie walking
		  //zombie = GameObject.FindWithTag ("enemies");
  }

  // Update is called once per frame
  void Update() {
    Debug.Log("DEAD" + health);
    if (health > 0) {
      Move();
    }
    else {
      //  // zombie has been killed.
      Destroy(zombie);
      return;
    }
  }

    public void Move()
    {
      float dist = Vector3.Distance(transform.position, Spartan.position);
      //Debug.Log("health " + health);
      //if (transform.position != Spartan.position)
      if (dist > attackRange) {
	//makes Zombie move towards the Spartan
	transform.position = Vector3.MoveTowards(transform.position, Spartan.position, Time.deltaTime * speed);
      }
      else {
	//Debug.Log("standing near the Spartan");
	this.GetComponent<Animation>().Stop();
        Destroy(gameObject);
    }
    }

    public void LoseHealth(float damage)
    {
      //Debug.Log("damage  " + damage);
      if (damage > 0 && health > 0) {
	float newhealth = health - damage;
	Debug.Log("health before damage  " + health + "new health is " + newhealth);
	health = newhealth;
	if (health <= 0) {
	  Debug.Log("zombie has been killed.");
	  Destroy(zombie);
	  Debug.Log("zombie is " + zombie);
	}
      }
    }
    public float getHealth()
    {
      Debug.Log("getHealth is " + health);
      return health;
    }
  }