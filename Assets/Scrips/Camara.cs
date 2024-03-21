using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform player;
    Vector3 ruta;

    void Start()
    {
        ruta = transform.position - player.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = player.position + ruta;
        target.z = 0;
        transform.position = target;
    }
}
