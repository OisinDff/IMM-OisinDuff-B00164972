using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public int platformCount = 100;

    //max and min gap between tiles
    public float xRange = 4.5f;
    public float yMinGap = 0.5f;
    public float yMaxGap = 2f;

    void Start()
    {
        Vector3 spawnPosition = Vector3.zero;

        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(yMinGap, yMaxGap);
            spawnPosition.x = Random.Range(-xRange, xRange);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
