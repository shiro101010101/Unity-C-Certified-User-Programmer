﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Platform : MonoBehaviour
{
    [SerializeField] float speed = 1;

   
    void Start()
    {
        
    }

    void Update()
    {

        transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        if(transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
