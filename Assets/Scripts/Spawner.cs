using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1.5f;
    public float maxHeight = 2f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(spawn));
    }

    private void spawn()
    {
        
        GameObject pipes = Instantiate(prefab,transform.position,Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight,maxHeight);
    }



}
