using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowBehavior : MonoBehaviour
{   
    private GameObject window;
    private GameObject rock;
    public GameObject myPrefab;
    public GameObject mySpecialPrefab;
   

    //Start is called before first frame update
    void Start()
    {
        rock = GameObject.Find("rock");
        window = gameObject;
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject == rock)
        {
            Destroy(gameObject);
            Instantiate(mySpecialPrefab, new Vector3(-56.5f, 12.8f, 0), Quaternion.identity);
            Instantiate(myPrefab, new Vector3(-56.5f, 13.8f, 0), Quaternion.identity);
            Instantiate(myPrefab, new Vector3(-56.5f, 14.8f, 0), Quaternion.identity);
            Instantiate(myPrefab, new Vector3(-56.5f, 11.8f, 0), Quaternion.identity);
            Instantiate(myPrefab, new Vector3(-56.5f, 10.8f, 0), Quaternion.identity);
            //go1.transform.position = new Vector2D(-56.5f, 13.8f);
        }
    }


    void Update()
    {
        
    }
}