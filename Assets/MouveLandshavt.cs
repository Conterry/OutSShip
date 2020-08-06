using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouveLandshavt : MonoBehaviour
{

    public GameObject SeaSpawn;
    public Transform PointToSeaSpawn;
    public GameObject Sea;

    void Update()
    {
        Sea.transform.Translate(Vector3.back * Time.deltaTime);
    }
    
    private void OnCollisionEnter(Collision Sea)
    {
        SpawnSea();
    }

    public void SpawnSea()
    {
        Instantiate(Sea, SeaSpawn.transform.position , Quaternion.identity);
    }
}
