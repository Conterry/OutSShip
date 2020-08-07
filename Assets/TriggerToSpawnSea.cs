using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerToSpawnSea : MonoBehaviour
{

    public GameObject SeaSpawn;
    public GameObject Sea;
    public GameObject SeaPrefab;
    public int GameSpeed;

    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }

    public void OnTriggerEnter(Collider SeaPrefab)
    {
        SpawnSea();
    }

    public void SpawnSea()
    {
        GameObject sea = Instantiate(SeaPrefab, SeaSpawn.transform.position, Quaternion.identity);
        GetComponent<Rigidbody>().velocity = new Vector3(0, GameSpeed);
    }
}
