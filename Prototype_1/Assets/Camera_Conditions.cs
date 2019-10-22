using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Conditions : MonoBehaviour
{

    public bool Normal_Gameplay;

    public Multiple_Target_Camera Normal_Gameplay_Camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Normal_Gameplay == true)
        {
            Normal_Gameplay_Camera.enabled = true;
        }
        else
        {
            Normal_Gameplay_Camera.enabled = false;
        }
    }
}
