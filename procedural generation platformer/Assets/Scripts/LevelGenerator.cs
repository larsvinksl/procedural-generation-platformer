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
                            GameObject instance1 = Instantiate(C1);
                            Transform C1SP = instance1.transform.Find("SnapPoint");
                            Transform C1Snap = instance1.transform.Find("Snapper");
                            Vector3 offset1 = C1Snap.position - instance1.transform.position;
                            instance1.transform.position = LastPoint.position - offset1;
                            LastPoint = C1SP;
                            do
                            {
                                rnd = Random.Range(1, 3);
                                switch (rnd)
                                {
                                    case 1:
                                        GameObject instance6 = Instantiate(V1);
                                        Transform V1SP = instance6.transform.Find("SnapPoint");
                                        Transform V1Snap = instance6.transform.Find("Snapper");
                                        Vector3 offset6 = V1Snap.position - instance6.transform.position;
                                        instance6.transform.position = LastPoint.position - offset6;
                                        LastPoint = V1SP;
                                        break;
                                    default:
                                        break;
                                }
                            } while (rnd >= 2);                         
                            GameObject instance4 = Instantiate(C4);
                            Transform C4SP = instance4.transform.Find("SnapPoint");
                            Transform C4Snap = instance4.transform.Find("Snapper");
                            Vector3 offset4 = C4Snap.position - instance4.transform.position;
                            instance4.transform.position = LastPoint.position - offset4;
                            LastPoint = C4SP;
                            break;
                        case 2:
                            GameObject instance2 = Instantiate(C3);
                            Transform C3SP = instance2.transform.Find("SnapPoint");
                            Transform C3Snap = instance2.transform.Find("Snapper");
                            Vector3 offset2 = C3Snap.position - instance2.transform.position;
                            instance2.transform.position = LastPoint.position - offset2;
                            LastPoint = C3SP;
                            do
                            {
                                rnd = Random.Range(1, 3);
                                switch (rnd)
                                {
                                    case 1:
                                        GameObject instance7 = Instantiate(V2);
                                        Transform V2SP = instance7.transform.Find("SnapPoint");
                                        Transform V2Snap = instance7.transform.Find("Snapper");
                                        Vector3 offset7 = V2Snap.position - instance7.transform.position;
                                        instance7.transform.position = LastPoint.position - offset7;
                                        LastPoint = V2SP;
                                        break;
                                    default:
                                        break;
                                }
                            } while (rnd >= 2);
                            GameObject instance5 = Instantiate(C2);
                            Transform C2SP = instance5.transform.Find("SnapPoint");
                            Transform C2Snap = instance5.transform.Find("Snapper");
                            Vector3 offset5 = C2Snap.position - instance5.transform.position;
                            instance5.transform.position = LastPoint.position - offset5;
                            LastPoint = C2SP;
                            break;
                    }
                    break;
                default:
                    rnd = Random.Range(1, 5);
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
                        case 3:
                            GameObject instance3 = Instantiate(H3);
                            Transform H3SP = instance3.transform.Find("SnapPoint");
                            Transform H3Snap = instance3.transform.Find("Snapper");
                            Vector3 offset3 = H3Snap.position - instance3.transform.position;
                            instance3.transform.position = LastPoint.position - offset3;
                            LastPoint = H3SP;
                            break;
                        case 4:
                            GameObject instance4 = Instantiate(H4);
                            Transform H4SP = instance4.transform.Find("SnapPoint");
                            Transform H4Snap = instance4.transform.Find("Snapper");
                            Vector3 offset4 = H4Snap.position - instance4.transform.position;
                            instance4.transform.position = LastPoint.position - offset4;
                            LastPoint = H4SP;
                            break;
                    }
                    break;
            }
        }
    }
}
