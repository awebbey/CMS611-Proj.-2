using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POBehavior : MonoBehaviour
{
    private GameObject pigeon;
    public Sprite flyingpigeon;
    public Sprite pigeonsprite;
    private bool go;
    private bool first;
    private Vector3 pos;
    private SpriteRenderer sprenderer;
    // Start is called before the first frame update
    void Start()
    {
        pigeon = GameObject.Find("pigeon (1)");
        go = true;
        first = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (go)
        {
            if (first)
            {
                sprenderer = pigeon.GetComponent<SpriteRenderer>();
                sprenderer.sprite = flyingpigeon;
                first = false;
            }
            else
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
                    else
                    {
                        sprenderer = pigeon.GetComponent<SpriteRenderer>();
                        sprenderer.sprite = pigeonsprite;
                        go = false;
                    }
                }
            }
            
        }
        
        
    }
}
