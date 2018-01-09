using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    //public float speed = 0.3f;
    public float forceValue = 5f;
    Rigidbody rigidbody;
	void Start () {
        // Cogemos la referencia para que sea más óptimo.
        rigidbody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
        /*transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, Input.GetAxis("Jump") * Time.deltaTime,
            Input.GetAxis("Vertical") * Time.deltaTime);*/
	}

    /// <summary>
    /// Metodo usado para los movimientos fisicos. Por defecto son 50 veces por segundo.
    /// </summary>
    private void FixedUpdate()
    {
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Jump"),Input.GetAxis("Vertical")) * forceValue);
    }
}
