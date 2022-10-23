using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FashionistaBehavior : MonoBehaviour
{
    //private Color color1 = Color.yellow;
    //private Color color2 = Color.grey;
    //private bool escape = true;
    private GameObject fashionista;
    private GameObject poop;
    private GameObject pizza;
    public GameObject pooped_fashionista;
    private Vector3 pos;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        poop = GameObject.Find("poop");
        pizza = GameObject.Find("pizza");

        fashionista = gameObject;
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
        if (collider.gameObject == poop)
        {
            pos = fashionista.transform.position;
            Destroy(fashionista);
            Instantiate(pooped_fashionista, pos, Quaternion.identity);
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
        if (pizza == null)
        {
            isMoving = true;
        }

        if (isMoving)
        {
            if (fashionista.transform.position.x < 10)
            {
                fashionista.transform.position += new Vector3(0.03f, 0, 0);
            }
        }
    }
}