﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightTeleport : MonoBehaviour
{
    [SerializeField] Transform exitportal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player" && collision.GetComponent<KnightExclusive>())
        { 
            collision.transform.position = exitportal.position;
        }
    }
}
