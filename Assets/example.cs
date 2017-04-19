using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class example : MonoBehaviour {

	//public GameObject horseObject;

	//public GameObject pearObject;

	//public GameObject pear1Object;

	//public GameObject appleObject;

	//public GameObject gameObject;
	//private Vector3 horseposition = new Vector3();

	public string foodType = "Fruits";

	public Vector3 pos;
	public Vector3 pos1;
	public Vector3 pos2;
	public Vector3 pos3;

	private float dist;

	private float dist1;

	//public Transform target;

	//public float speed;

	//public Transform Apple;

	//public Dictionary weapons = new Dictionary(); 

	// Use this for initialization
	void Start () {
		
		//horseposition = GameObject.FindGameObjectWithTag("horse").transform.position;

		pos= GameObject.FindGameObjectWithTag ("horse").transform.position;

		pos1 = GameObject.FindGameObjectWithTag ("fruit_pear").transform.position;

		pos2 = GameObject.FindGameObjectWithTag ("fruit_pear1").transform.position;

		pos3 = GameObject.FindGameObjectWithTag ("apple").transform.position;


	}

	// Update is called once per frame
	void Update () {

		//gob.transform.position = Vector3.up * Time.deltaTime;
		//Debug.Log (transform.position);


		//horseposition = horseObject.transform.position.x;

		

		dist = Vector3.Distance(pos, pos1);

		dist1 = Vector3.Distance (pos, pos2);

		//Debug.Log("dist is " + dist );

		Debug.Log ("pos is " + pos);


		//float step = speed * Time.deltaTime;
		//transform.position = Vector3.MoveTowards(transform.position, target.position, step);

		
	}

	//void DoAIBehaviour () {
		//Debug.Log ("example::DoAIBehaviour");
	//}



	//void Example() {
		//if (Apple) {
			//float dist = Vector3.Distance(Apple.position, transform.position);
			//print("Distance to Apple: " + dist);
		//}
	//}
}
