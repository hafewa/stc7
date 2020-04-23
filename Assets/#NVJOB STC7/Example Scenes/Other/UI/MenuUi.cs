﻿using UnityEngine;
using UnityEngine.UI;


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


public class MenuUi : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    

    public Text typeText;
    public GameObject nExample;


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    void LateUpdate()
    {
        //--------------

        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();

        typeText.text = nExample.activeSelf ? "#NVJOB STC 7" : "Standard Shader for SpeedTree 7";

        //--------------
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}