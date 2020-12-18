using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activatescene : MonoBehaviour
{

    bool IsPause;

    // Use this for initialization
    void Start()
    {
        IsPause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            
            if (IsPause == false)
            {
                Time.timeScale = 0;
                IsPause = true;
                return;
            }

           
            if (IsPause == true)
            {
                Time.timeScale = 1;
                IsPause = false;
                return;
            }
        }
    }
}


