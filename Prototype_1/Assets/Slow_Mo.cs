using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow_Mo : MonoBehaviour
{
    public float TimeScale;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = TimeScale;
    }

    private void FixedUpdate()
    {
       
    }
}
