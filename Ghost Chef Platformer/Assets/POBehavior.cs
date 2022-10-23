using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POBehavior : MonoBehaviour
{
    private GameObject pigeon;
    // Start is called before the first frame update
    void Start()
    {
        pigeon = GameObject.Find("pigeon");
    }

    // Update is called once per frame
    void Update()
    {
        if (pigeon.transform.position.y < 30)
        {
            pigeon.transform.position += new Vector3(0, 0.1f, 0);
        }
        else
        {
            if (pigeon.transform.position.x < 10)
            {
                pigeon.transform.position += new Vector3(0.1f, 0, 0);
            }
        }
        
    }
}
