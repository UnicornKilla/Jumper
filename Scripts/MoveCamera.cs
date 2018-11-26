using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform player;
    Vector3 position;
	
	void Start () {
        transform.position = player.position;
	}
	
	
	void Update () {
        position = player.position;
        position.z = -10f;
        position.x = 0f;
        transform.position = Vector3.Lerp(transform.position, position, 1f * Time.deltaTime);
	}
}
