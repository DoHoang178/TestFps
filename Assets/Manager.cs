using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Manager : MonoBehaviour
{
    public float updateInterval = 0.5f;
    private float lastInterval;
    private int frames = 0;
    private float fps;
    [SerializeField] private TextMeshProUGUI txtFPS;

    void Update()
    {
        frames++;
        if (Time.time > lastInterval + updateInterval)
        {
            fps = frames / updateInterval;
            frames = 0;
            lastInterval = Time.time;
            fps = (int)fps;
            txtFPS.text = "FPS: " + fps;
        }
    }
}
