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
    public GameObject poop;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        bread = GameObject.Find("moldy bread");
        pigeon = gameObject;
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject == bread)
        {
            Destroy(bread);
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
        if (pos.x >= 10 && bread == null)
        {
            Instantiate(poop, new Vector3(pos.x, pos.y - 3.0f, 0), Quaternion.identity);
        }
    }
}

