using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float forcePower = 0.1f;
    Rigidbody rigidbody;
    public float jumpValue = 0.1f;
    public float prueba;
    private AudioSource audiosource;
    private GameObject capsules;
    public GameObject prefab;
    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audiosource = GetComponent<AudioSource>();
        capsules = GameObject.Find("Capsules");
    }

    // Update is called once per frame
    void Update()
    {
        prueba = Mathf.Abs(rigidbody.velocity.y);
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody.velocity.y) <0.2f)
        {
            rigidbody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
            audiosource.Play();
            
        }
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * forcePower);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Cubo"))
        {
            print("Colisión con cubo");
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag.Equals("Capsule"))
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color *= 1.2f;
            collision.gameObject.GetComponent<AudioSource>().Play();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Capsule"))
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color /= 1.2f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        foreach (Transform child in capsules.GetComponentInChildren<Transform>())
        {
            if (child.gameObject.tag.Equals("Capsule"))
            {
                child.gameObject.GetComponent<MeshRenderer>().enabled = true;
                child.gameObject.GetComponent<CapsuleCollider>().enabled = true;
            }
        }
        Instantiate(prefab, new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f)), Quaternion.identity);
    }
}
