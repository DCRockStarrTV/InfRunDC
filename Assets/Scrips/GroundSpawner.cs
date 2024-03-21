using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject pisos;
    Vector3 SigPiso;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(pisos, SigPiso, Quaternion.identity);
        SigPiso = temp.transform.GetChild(1).transform.position;
    }

    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnTile();
        }
    }

}
