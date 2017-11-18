using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {

    public Quaternion camrot;
    public Vector3 campos;
    public GameObject parent;
	// Use this for initialization
	void Start () {
        camrot = transform.rotation;
        campos = transform.position - parent.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {

        transform.rotation = camrot;
        transform.position = parent.transform.position + campos;


    }
}
