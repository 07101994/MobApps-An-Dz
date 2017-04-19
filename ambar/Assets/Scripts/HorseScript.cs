using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseScript:MonoBehaviour
{
    GameObject pathGO;  //foodGO;
    Transform targetPathNode;

    //string foodObjectName = "Apple";
    private float moveIncrX, moveIncrZ; //   x: [+towards the right side of QR code, -towards the left] 
    private Animation anim; //Horse object's animation
    //@params x, y, z
    private Vector3 horsePos;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animation>();
        anim.Play();
        //horsePos = transform.position;
        //pathGO = GameObject.Find("Apple");
        //moveIncrX = 0.5f;
        //moveIncrZ = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        // https://www.youtube.com/watch?v=YfIOPWuUjn8&index=16&list=PLytjVIyAOStpT8xJyijH4uG4nEPexvj18
        //transform.Translate(moveIncrZ * Time.deltaTime, 0, moveIncrZ * Time.deltaTime);
        //horsePos.x += moveIncrX;
        //transform.position = (horsePos.x, horsePos.y, horsePos.z); 
        //Debug.Log (transform.position.x);

    }
}
