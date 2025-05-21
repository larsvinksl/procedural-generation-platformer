using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public corridor1 corridor1;

    public GameObject H1;
    Transform H1SP;
    Transform H1Snap;

    public GameObject H2;

    public GameObject C1;
    public GameObject C2;

    public GameObject V1;

    public Transform Detector;

    public Transform LastPoint;

    int rnd;

    void Start()
    {
        H1SP = corridor1.snapPoint;
        H1Snap = corridor1.snapper;
    }

    void Update()
    {
        if (Detector.position.x > LastPoint.position.x)
        {
            Vector3 spawnPosition = H1.transform.TransformPoint(H1SP.localPosition);
            Instantiate(H1, spawnPosition, Quaternion.identity);
            LastPoint = H1SP;
        }
    }
}
