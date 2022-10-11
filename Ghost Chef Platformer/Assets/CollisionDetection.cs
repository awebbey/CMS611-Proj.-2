using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private Color color1 = Color.yellow;
    private Color color2 = Color.grey;
    private bool escape = true;

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.backgroundColor = color2;
    }

    void OnCollisionEnter2D()
    {
        //Debug.Log("hit em");
        if (escape)
        {
            if (Camera.main.backgroundColor == color1)
            {
                Camera.main.backgroundColor = color2;
            }
            else
            {
                Camera.main.backgroundColor = color1;
            }
            escape = false;

        }
    }

    void OnCollisionExit2D()
    {
        //Debug.Log("hit em");
        escape = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
