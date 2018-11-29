using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Record : MonoBehaviour {

	void Start () {
        GetComponent<Text> ().text = PlayerPrefs.GetInt("Score").ToString();
		
	}
	
	
}
