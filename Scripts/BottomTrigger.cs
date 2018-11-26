using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomTrigger : MonoBehaviour {

	
	void Start ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Platform")
        {
            Destroy(other.gameObject);
        }

    }

    void Update () {
		
	}
}
