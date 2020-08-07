using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouveLandshavt : MonoBehaviour
{

    public GameObject SeaSpawn;
    public GameObject Sea;
    public GameObject SeaPrefab;
    public int GameSpeed;

    void Update()
    {
        Sea.transform.Translate(Vector3.back * Time.deltaTime * GameSpeed);
    }

}
