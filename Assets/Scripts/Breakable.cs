using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{

    public float breakforce = 5f;
    public bool isBreakable = true;
    // Use this for initialization
    void Start()
    {
        breakforce = 5f;
      //  isBreakable = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.relativeVelocity.magnitude);

        if ((collision.relativeVelocity.magnitude >= breakforce)&&isBreakable)
        {
            Debug.Log("break this");
            Destroy(gameObject);
        }
            
    }
}