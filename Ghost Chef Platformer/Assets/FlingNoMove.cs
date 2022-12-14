using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlingNoMove : MonoBehaviour
{

    private Vector2 ballPosition;
    private Vector2 releasePosition;
    private bool didMouseDown;
    private bool didMouseUp;
    public float forceMulitplier = 100;
    //public float totalDistance;
    //public int strokes;
    private float ballRadius;
    //private gameObject = GameObject.Find("SampleScene/Circle");


    void ResetMouse()
    {
        didMouseUp = false;
        didMouseDown = false;
    }

    void Start()
    {
        ResetMouse();
        //figure out how to reference the game object's circle collider
        ballRadius = 0.5f;
        ballPosition = gameObject.transform.position;
        //totalDistance = 0f;
        //strokes = 0;
    }

    void OnMouseDown()
    {
        if (GetComponent<Rigidbody2D>().velocity.magnitude < 0.1)
        {
            didMouseDown = true;
            ballPosition = gameObject.transform.position;
        }
        
    }

    void OnMouseUp()
    {
        if (didMouseDown)
        {
            releasePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            didMouseUp = true;
        }
        
    }

    void Update()
    {
        //private not_moving = GetComponent<Rigidbody2D>().velocity.magnitude;

        //IF the mouse button was clicked inside and then outside of the ball's raius then add force
        if ((didMouseUp && didMouseDown) && (Vector2.Distance(ballPosition, releasePosition) > ballRadius))// && not_moving)
        {
            GetComponent<Rigidbody2D>().AddForce((ballPosition - releasePosition) * forceMulitplier);           
            //GetComponent<Rigidbody2D>().AddForce((ballPosition - releasePosition) * forceMulitplier);
            //			Debug.Log ("total force before multiplier: " + (ballPosition - releasePosition)* forceMulitplier);
            //audio.Play();
            ResetMouse();
            //GameControl.control.strokes++;
            //var gameInst = GameObject.Find("Instructions");
            //Destroy(gameInst);
        }

        if (didMouseDown)
        {

        }



        //		Vector2 currentPosition = gameObject.transform.position;

        //		if (ballPosition != currentPosition)
        //		{
        //			//GameControl.control.totalDistance += Vector2.Distance(currentPosition, ballPosition);
        //			ballPosition = currentPosition;
        //		}

    }

}