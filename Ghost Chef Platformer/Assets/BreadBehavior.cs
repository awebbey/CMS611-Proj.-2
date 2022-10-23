using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadBehavior : MonoBehaviour
{
    //private Color color1 = Color.yellow;
    //private Color color2 = Color.grey;
    //private bool escape = true;
    private GameObject pigeon;
    private GameObject bread;

    // Start is called before the first frame update
    void Start()
    {
        pigeon = GameObject.Find("pigeon");
        bread = gameObject;
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        //Debug.Log("hit em");
        //if (escape)
        //{
        //    if (Camera.main.backgroundColor == color1)
        //    {
        //        Camera.main.backgroundColor = color2;
        //    }
        //    else
        //    {
        //        Camera.main.backgroundColor = color1;
        //    }
        //    escape = false;

        //}
        if (collider.gameObject == pigeon)
        {
            Destroy(gameObject);
        }
    }

    //void OnCollisionExit2D()
    //{
    //    //Debug.Log("hit em");
    //    escape = true;
    //}

    // Update is called once per frame
    void Update()
    {

    }
}
