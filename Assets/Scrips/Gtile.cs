using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gtile : MonoBehaviour
{
    GroundSpawner GS;

    void Start()
    {
        GS = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObject();
    }

    private void OnTriggerExit(Collider other)
    {
        GS.SpawnTile();
        Destroy(gameObject, 2);
    }

    public GameObject ObsPref;

    void SpawnObject()
    {
        int obsIndx = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obsIndx).transform;

        Instantiate(ObsPref, spawnPoint.position, Quaternion.identity, transform);
    }

    
}
