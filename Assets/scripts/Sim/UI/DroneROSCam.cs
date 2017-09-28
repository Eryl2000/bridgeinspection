﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroneROSCam : MonoBehaviour {
    private GameManager gameManager;
    private ROSManager rosManager;

    private RawImage rawImage;

    // Use this for initialization
    void Start()
    {
        gameManager = GameManager.getInstance();
        rosManager = gameManager.getROSManager();

        rawImage = this.gameObject.GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnGUI()
    {
        rawImage.texture = rosManager.getdroneCam();
    }

    public void ToggleDroneCam(bool toggle)
    {
        if (rawImage.enabled)
        {
            rawImage.enabled = false;
        }
        else
        {
            rawImage.enabled = true;
        }
    }
}
