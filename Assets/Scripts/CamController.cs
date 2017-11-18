using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {

    public Quaternion camrot;

	// Use this for initialization
	void Start () {
        camrot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = camrot;

	}
}
