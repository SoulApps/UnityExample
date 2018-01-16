using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour {
    public GameObject prefab;
    public float fireRate = 0.1f;
	// Use this for initialization
	void Start () {
        StartCoroutine(ThrowObject());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator ThrowObject()
    {
        yield return new WaitForSeconds(fireRate);
        while (true)
        {
            // instanciamos el objeto
            Instantiate(prefab, transform.position, Random.rotation);
            // hacemos un return parcial
            yield return new WaitForSeconds(fireRate);
            // Si queremos que se haga  en cada frame --> yield return null;
        }
    }
}
