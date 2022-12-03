﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("ChallengeObj Game Object")]
    public GameObject challengeObj;
    [Header("Default Spawn Delay Time")]
    public float spawnDelay = 1f;
    [Header("Default Spawn Time")]
    public float spawnTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(15, -2.75f, 0);
    }
    void InstantiateObjects()
        {
        Instantiate(challengeObj, transform.position, transform.rotation);
        }
}
