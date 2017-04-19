using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie:MonoBehaviour {
  public Transform Spartan;  //Spartan King object
			     //public GameObject zombie; //Zombie object
  private float speed, //Zombie moving speed
    stopRange;  // at this range zombie will stop moving and attack
  private Animation anim;  //Zombie object's animation
			   //private float health = 100f;

  // Use this for initialization
  void Start() {
    speed = 0.5f;
    stopRange = 1f;
    anim = this.GetComponent<Animation>();
    //TODO: start moving only if the marker has been seen
    anim.Play();  //animate zombie walking
		  //zombie = GameObject.FindWithTag ("enemies");
  }

  // Update is called once per frame
  void Update() {
    if (transform.position != Spartan.position) {
      //makes Zombie move towards the Spartan
      transform.position = Vector3.MoveTowards(transform.position, Spartan.position, Time.deltaTime * speed);
    }
    else {
      //  Debug.Log("standing near the Spartan");
      this.GetComponent<Animation>().Stop();
    }
    

    //Destroy (gameObject);
  }
}