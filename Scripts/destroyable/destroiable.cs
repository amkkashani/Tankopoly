﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroiable : MonoBehaviour
{
    public float health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Healthset(float amount)
    {
        health -= amount;
    }
}
