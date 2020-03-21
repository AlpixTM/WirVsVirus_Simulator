﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimulationMasterTickEventArg : EventArgs
{
    public int TimeStep;
}

public class SimulationMaster : MonoBehaviour
{
    public bool isRunning;
    public int timeStep;

    public event EventHandler<SimulationMasterTickEventArg> UnityUpdate;


    public Button PlayButton;
    public Button PauseButton;

    public void Run()
    {
        isRunning = true;
        PlayButton.gameObject.SetActive(false);
        PauseButton.gameObject.SetActive(true);
    }

    public void Pause()
    {
        isRunning = false;
        PlayButton.gameObject.SetActive(true);
        PauseButton.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (!isRunning)
            return;
        timeStep += 1;
        UnityUpdate?.Invoke(this, new SimulationMasterTickEventArg()
        {
            TimeStep = timeStep
        }); ;
    }
}
