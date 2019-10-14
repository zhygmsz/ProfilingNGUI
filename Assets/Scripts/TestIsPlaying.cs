using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestIsPlaying : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Application.isPlaying)
        {
            int val = 1;
        }
        else
        {
            int val = 1;
        }

        if (Application.isEditor)
        {
            int val = 1;
        }
        else
        {
            int val = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        int val = 1;
    }
}
