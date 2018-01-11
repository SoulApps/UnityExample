using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{


    public GameObject player;
    private Vector3 offset;


    void Start()
    {
        // Se calcula y se almacena la distancia entre la camara y el jugador
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
