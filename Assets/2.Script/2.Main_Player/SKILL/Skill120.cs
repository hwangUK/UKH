using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill120 : MonoBehaviour {
    Transform target;
    public float speed = 0.3f;
	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Mon").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target.position + new Vector3(0f, 4f, 0f), speed);
	}
}
