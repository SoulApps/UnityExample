using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 0.3f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, Input.GetAxis("Jump") * Time.deltaTime,
            Input.GetAxis("Vertical") * Time.deltaTime);
	}
}
