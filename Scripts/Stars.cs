using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour {

    public GameObject star;

	void Start () {
        StartCoroutine(spawnstar());
		
	}

    IEnumerator spawnstar()
    {
        while (true)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2));
            Instantiate(star, pos, Quaternion.identity);
            yield return new WaitForSeconds(5.01f);
        }
    }
	
	
}
