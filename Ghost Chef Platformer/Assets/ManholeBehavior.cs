using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManholeBehavior : MonoBehaviour
{
    private GameObject manhole;
    private GameObject pizza;
    public GameObject Rat;
    private Vector3 pizza_pos;

    //Start is called before first frame update
    void Start()
    {
        pizza = GameObject.Find("pizza");
        manhole = gameObject;
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
        if (collider.gameObject == pizza)
        {
            pizza_pos = pizza.transform.position;
            Destroy(pizza);
            Instantiate(Rat, pizza_pos, Quaternion.identity);
        }
    }

    void Update()
    {

    }
}