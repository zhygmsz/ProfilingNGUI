using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestIsPlaying : MonoBehaviour
{
    public UIPanel panel1;
    public UIPanel panel2;
    public GameObject mGo;

    private void Awake()
    {
        UIEventListener.Get(gameObject).onClick = (GameObject go) =>
        {
            mGo.transform.parent = panel2.transform;
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        //mGo.transform.parent = panel2.transform;

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
