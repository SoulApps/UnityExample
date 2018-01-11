using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float forcePower = 0.1f;
    Rigidbody rigidbody;
    public float jumpValue = 0.1f;
    public float prueba;
    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        prueba = Mathf.Abs(rigidbody.velocity.y);
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody.velocity.y) <0.2f)
        {
            rigidbody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
            
        }
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * forcePower);
    }
}
