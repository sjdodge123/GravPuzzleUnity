﻿using UnityEngine;
using System.Collections;

public class Level5 : RuleManager {

    // Use this for initialization
    void Start () {
        InitializeLevel();
        ballBody.velocity = new Vector2(0, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
