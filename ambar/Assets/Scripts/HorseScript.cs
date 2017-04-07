using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseScript : MonoBehaviour
{
	GameObject pathGO;	//foodGO;
	Transform targetPathNode;

	//string foodObjectName = "Apple";
	private float moveIncrX = 0.0625f, //   x: [+towards the right side of QR code, -towards the left] 
		moveIncrZ = 0.0625f;
	//	z: [-left, +right]

	//@params x, y, z
	private Vector3 horsePos;
	// Use this for initialization
	void Start ()
	{
		horsePos = transform.position;
		pathGO = GameObject.Find ("Apple");
	}
	void GetNextPathNode(){
		//targetPathNode = pathGO.transform;
		//Debug.Log (targetPathNode);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		//moveIncrX = -1 * moveIncrX;
// https://www.youtube.com/watch?v=YfIOPWuUjn8&index=16&list=PLytjVIyAOStpT8xJyijH4uG4nEPexvj18

		//transform.Translate (0, 0, moveIncrZ * Time.deltaTime);
		//transform.Translate (moveIncrX * Time.deltaTime, 0, moveIncrZ * Time.deltaTime);

		//for (i = ;
		/*
		horseAPos.x += moveIncrX;
		transform.position = horseAPos.x; 
		Debug.Log (transform.position.x);
		*/
		
	}
}
