using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject H1;

    public GameObject H2;

    public GameObject C1;
    public GameObject C2;

    public GameObject V1;

    public Transform Detector;

    public Transform LastPoint;

    int rnd;

    void Update()
    {
        if (Detector.position.x > LastPoint.position.x)
        {
            rnd = Random.Range(1, 3);
            switch (rnd)
            {
                case 1:
                    GameObject instance1 = Instantiate(H1);
                    Transform H1SP = instance1.transform.Find("SnapPoint");
                    Transform H1Snap = instance1.transform.Find("Snapper");
                    Vector3 offset1 = H1Snap.position - instance1.transform.position;
                    instance1.transform.position = LastPoint.position - offset1;
                    LastPoint = H1SP;
                    break;
                case 2:
                    GameObject instance2 = Instantiate(H2);
                    Transform H2SP = instance2.transform.Find("SnapPoint");
                    Transform H2Snap = instance2.transform.Find("Snapper");
                    Vector3 offset2 = H2Snap.position - instance2.transform.position;
                    instance2.transform.position = LastPoint.position - offset2;
                    LastPoint = H2SP;
                    break;
            }
        }
    }
}
