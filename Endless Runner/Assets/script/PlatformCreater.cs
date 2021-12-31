using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreater : MonoBehaviour
{

    [SerializeField] GameObject platformPrefab;
    [SerializeField] Transform referencePoint;
    private GameObject lastCreatedPlatform;

    void Start()
    {
        //lastCreatedPlatform = Instantiate(platformPrefab,referencePoint.position,Quaternion.identity
            );
    }

    void Update()
    {
        //Create a new platform when the previous one reaches 0
        if(lastCreatedPlatform.transform.position.x < 0)
        {
            lastCreatedPlatform = Instantiate(platformPrefab, referencePoint.position, Quaternion.identity
            );
        }
    }
}
