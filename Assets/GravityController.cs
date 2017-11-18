using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour {


    public float xpos;
    public float ypos;
    public Vector3 mousepos;

    public float gravpower =10f;

	// Use this for initialization
	void Start () {
        gravpower = 10f;
        Physics.gravity = new Vector3(0, 10.0F, 0);
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        mousepos = Input.mousePosition;
        mousepos.x = mousepos.x / Screen.width;
        mousepos.y = mousepos.y / Screen.height;

        mousepos = mousepos * 2;

        mousepos.x = mousepos.x - 1;
        mousepos.y = mousepos.y - 1;

        mousepos = mousepos * gravpower;
        Physics.gravity = mousepos;

    }

    



}
