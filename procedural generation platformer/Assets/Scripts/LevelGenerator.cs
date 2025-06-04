using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject H1;
    public GameObject H2;
    public GameObject H3;
    public GameObject H4;

    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;

    public GameObject V1;
    public GameObject V2;

    public Transform Detector;
    public Transform LastPoint;
    public FogBehaviour Fog;

    int rnd;

    void Update()
    {
        if (Detector.position.x > LastPoint.position.x)
        {
            rnd = Random.Range(1, 4);
            switch (rnd)
            {
                case 1:
                    rnd = Random.Range(1, 3);
                    switch (rnd)
                    {
                        case 1:
                            generate(C1);
                            do
                            {
                                rnd = Random.Range(1, 3);
                                switch (rnd)
                                {
                                    case 1:
                                        generate(V1);
                                        break;
                                    default:
                                        break;
                                }
                            } while (rnd >= 2);
                            generate(C4);
                            break;
                        case 2:
                            generate(C3);
                            do
                            {
                                rnd = Random.Range(1, 3);
                                switch (rnd)
                                {
                                    case 1:
                                        generate(V2);
                                        break;
                                    default:
                                        break;
                                }
                            } while (rnd >= 2);
                            generate(C2);
                            break;
                    }
                    break;
                default:
                    rnd = Random.Range(1, 5);
                    switch (rnd)
                    {
                        case 1:
                            generate(H1);
                            break;
                        case 2:
                            generate(H2);
                            break;
                        case 3:
                            generate(H3);
                            break;
                        case 4:
                            generate(H4);
                            break;
                    }
                    break;
            }
        }
    }

    void generate(GameObject room)
    {
        GameObject instance = Instantiate(room);
        Transform SP = instance.transform.Find("SnapPoint");
        Transform Snap = instance.transform.Find("Snapper");
        Vector3 offset = Snap.position - instance.transform.position;
        instance.transform.position = LastPoint.position - offset;
        Fog.AddSegment(instance);
        LastPoint = SP;
    }
}
