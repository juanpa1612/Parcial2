using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletExplosion : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        RaycastHit hit;
        if (Physics.SphereCast(gameObject.transform.position, 2f, transform.forward, out hit, 10))
        {
            
        }

    }
}
