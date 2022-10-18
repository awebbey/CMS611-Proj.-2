using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    private Vector2 buttonPosition;
    private Vector3 mousePosition;
    private float buttonWidth;
    private float buttonHeight;
    private float xpos;
    private float ypos;

    // Start is called before the first frame update
    void Start()
    {
        buttonWidth = 10f;
        buttonHeight = 5f;
        buttonPosition = gameObject.transform.position;
    }

    //void OnMouseDown()
    //{
    //    Debug.Log("Button Clicked");
    //    //mousepoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    //buttonPosition = gameObject.transform.position;
    //    //didMouseDown = true;
    //    //button = buttonWidth - buttonHeight;
    //    xpos = mousePosition.x - buttonPosition.x;
    //    ypos = mousePosition.y - buttonPosition.y;
    //    if (xpos < 0)
    //    {
    //        xpos = -1 * xpos;
    //    }
    //    if (ypos < 0)
    //    {
    //        ypos = -1 * xpos;
    //    }
    //    if (xpos < buttonWidth/2 && ypos < buttonHeight/2)
    //    {
    //        Debug.Log("Button Clicked");
    //    }

    //    //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    //}
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log(mousePosition.x);
            //Debug.Log(buttonPosition.x);

            xpos = mousePosition.x - buttonPosition.x;
            ypos = mousePosition.y - buttonPosition.y;
            if (xpos < 0)
            {
                xpos = -1 * xpos;
            }
            if (ypos < 0)
            {
                ypos = -1 * xpos;
            }
            if (xpos < buttonWidth / 2 && ypos < buttonHeight / 2)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}

