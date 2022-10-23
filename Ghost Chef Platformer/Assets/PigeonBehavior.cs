using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonBehavior : MonoBehaviour
{
    //private Color color1 = Color.yellow;
    //private Color color2 = Color.grey;
    //private bool escape = true;
    private GameObject pigeon;
    private GameObject bread;
    private GameObject overhang;
    public GameObject poop;
    private bool isFed;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        bread = GameObject.Find("moldy bread");
        overhang = GameObject.Find("birdPerch");
        pigeon = gameObject;
        isFed = false;
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
        if (collider.gameObject == bread)
        {
            Destroy(bread);
            isFed = true;
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
        pos = pigeon.transform.position;
        if (pos.x >= 10 && isFed)
        {
            Instantiate(poop, new Vector3(pos.x, pos.y - 3.0f, 0), Quaternion.identity);
        }
    }
}

