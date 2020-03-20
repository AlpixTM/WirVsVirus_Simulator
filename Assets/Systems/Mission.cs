﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Mission
{
    public System.Type Destination;
    public int Counter = 50; // time until someone has to go there
    public int Duration = 10; // how long to stay there
    public int MaxCounter = 50;
    public int MaxDuration = 20;
}