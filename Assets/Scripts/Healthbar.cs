using UnityEngine;
using System.Collections;

public class Healthbar : MonoBehaviour {

	Spartan s;

	// Use this for initialization
	void Start () {
		s = transform.parent.GetComponent<Spartan>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3(1, Mathf.Clamp01(s.health/100f), 0);
	}
}
