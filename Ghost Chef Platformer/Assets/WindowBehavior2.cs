using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class WindowBehavior2 : MonoBehaviour
{
    //private Color color1 = Color.yellow;
    //private Color color2 = Color.grey;
    //private bool escape = true;
    private bool swOn;
    private Stopwatch sw;
    public GameObject PO;
    private bool spawnPO;

    // Start is called before the first frame update
    void Start()
    {
        sw = new Stopwatch();
        swOn = false;
        spawnPO = true;
    }
    void Update()
    {
        if (spawnPO)
        {
            sw.Start();
            spawnPO = false;
            swOn = true;
        }
        if (swOn)
        {
            if (sw.ElapsedMilliseconds > 2000)
            {
                Instantiate(PO, new Vector3(-50.5f, 0, 0), Quaternion.identity);
                sw.Reset();
                swOn = false;
            }
        }

    }
}