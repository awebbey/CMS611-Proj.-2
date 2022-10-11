using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererScript : MonoBehaviour
{

    Vector3 startPos;
    Vector3 endPos;
    Camera camera;
    LineRenderer lr;

    Vector3 camOffset = new Vector3(0, 0, 25);

    //[SerializeField] AnimationCurve ac;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            if (lr == null)
            {
                lr = gameObject.AddComponent<LineRenderer>();
                lr.enabled = true;
                lr.positionCount = 2;
                lr.startWidth = 0.1f;
                lr.endWidth = 0.1f;
                //lr.startColor = (1, 1, 1, 0);
                //lr.endColor = (.5, .5, .5, .9);
                startPos = camera.ScreenToWorldPoint(Input.mousePosition) + camOffset;
                lr.SetPosition(0, startPos);
            }
                //Debug.Log(camera.ScreenToWorldPoint(Input.mousePosition));
            if (lr.enabled == false)
            { 
                lr.enabled = true;
                lr.positionCount = 2;
                startPos = camera.ScreenToWorldPoint(Input.mousePosition) + camOffset;
                lr.SetPosition(0, startPos);
                //lr.width = 0.1;
                //lr.color = (255, 255, 255);
            }
            //startPos = camera.ScreenToWorldPoint(Input.mousePosition) + camOffset;
            //lr.SetPosition(0, startPos);
            lr.useWorldSpace = true;

            //lr.widthCurve = ac;
            //lr.numCapVertices = 10;
            endPos = camera.ScreenToWorldPoint(Input.mousePosition) + camOffset;
            lr.SetPosition(1, endPos);

        }
        else
        {
            if (lr != null)
            {
                lr.enabled = false;
            }
        }
    }
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        //Debug.Log(camera.ScreenToWorldPoint(Input.mousePosition));
    //        if (lr == null)
    //        {
    //            lr = gameObject.AddComponent<LineRenderer>();
    //        }
    //        lr.enabled = true;
    //        lr.positionCount = 2;
    //        startPos = camera.ScreenToWorldPoint(Input.mousePosition) + camOffset;
    //        lr.SetPosition(0, startPos);
    //        lr.useWorldSpace = true;
    //        //lr.widthCurve = ac;
    //        //lr.numCapVertices = 10;
    //        if (Input.GetMouseButton(0))
    //        {
    //            endPos = camera.ScreenToWorldPoint(Input.mousePosition) + camOffset;
    //            lr.SetPosition(1, endPos);
    //            //lr.SetPosition(startPos, endPos);
    //        }
    //        if (Input.GetMouseButtonUp(0))
    //        {
    //            lr.enabled = false;
    //        }
    //    }
    //}
}