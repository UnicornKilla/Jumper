using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour {

    public GameObject block;
    public Transform points;
	
	void Start () {

	}


    private void OnTriggerEnter2D(Collider2D other)
    {
        
            if (other.tag == "Player")
            {
                Instantiate(block, points.position, Quaternion.identity);
                Destroy(gameObject);
            }
               
    }

}
