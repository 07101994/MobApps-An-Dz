using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_SeekFood : MonoBehaviour {

	public string critterType = "Vegetable";

	public float eatingRange = 1f;
	public float eatHPPerSecond = 5f;
	public float eatHP2Energy = 2f;

	Critter myCritter;

	void Start () {
		myCritter = GetComponent<Critter>();
	}
	

	void DoAIBehaviour() {

		if(Critter.crittersByType.ContainsKey(critterType) == false) {
			// We have nothing to eat!
			return;
		}

		// Find the closest edible critter to us.
		Critter closest = null;
		float dist = Mathf.Infinity;

		foreach(Critter c in Critter.crittersByType[critterType]) {


			float d = Vector2.Distance(this.transform.position, c.transform.position);

			if(closest == null || d < dist) {
				closest = c;
				dist = d;
			}

		}

		if(closest == null) {
			// No valid food targets exist.
			return;
		}


		if(dist < eatingRange) {
			float hpEaten = Mathf.Clamp(eatHPPerSecond * Time.deltaTime, 0, closest.health);
			closest.health -= hpEaten;
			myCritter.energy += hpEaten * eatHP2Energy;
		}
		else {
			// Now we want to move towards this closest edible critter

			Vector2 dir = closest.transform.position - this.transform.position;

			WeightedDirection wd = new WeightedDirection( dir, 1 );

			myCritter.desiredDirections.Add( wd );
		}
	}

}
