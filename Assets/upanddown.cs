using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upanddown : MonoBehaviour {
    public float upvar;
    public float downvar;
    public float xrange;
    public float yrange;
   
    private object newPosition;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetMouseButtonDown(0))
        {    Vector3 newPosition = transform.position;
            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Mathf.Abs(mouse.x - newPosition.x) < xrange &&
                Mathf.Abs(mouse.y - newPosition.y) < yrange)
            { newPosition.y += upvar * Time.deltaTime;

            transform.position = newPosition;}
            

            
        }
		
        if(Input.GetMouseButtonUp(0))
        {
            Vector3 newPosition = transform.position;
            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Mathf.Abs(mouse.x - newPosition.x) < xrange &&
                Mathf.Abs(mouse.y - newPosition.y) < yrange)
            { newPosition.y += downvar * Time.deltaTime;

            transform.position = newPosition;}
                
        }
	}
}
