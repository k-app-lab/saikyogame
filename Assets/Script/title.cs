using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title : MonoBehaviour
{
    private bool firstPush = false;

    public void PressStart()
    {
        Debug.Log("Press Satrt");
        if (!firstPush)
        {
            Debug.Log("Go next");
        }
        
    }
}
