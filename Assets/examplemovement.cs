using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examplemovement : MonoBehaviour {
    public float upanddown;
    //0 = 올라감, 1 =대기, 2 = 내려옴, 3 = 아무것도 안함
    public int state = 3;
    public float time = 0.0f;
    
	// Use this for initialization
	void Start () {
        

        

	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;
        if(time > 4.0f)
        {
            time = 0.0f;
            state = state + 1;
        }

        if (state == 0)
        {
            Vector3 newPosition = transform.position;
            newPosition.y += Time.deltaTime * upanddown;
            transform.position = newPosition;

        }
        else if(state == 1)
        {

        }
        else if(state==2)
        {
            Vector3 newPosition = transform.position;
            newPosition.y -= Time.deltaTime * upanddown;
            transform.position = newPosition;
        }
        else if(state==3)
        {
               

        }
    }

    public void MoveStart()
    {
        state = 0;
        time = 0.0f;
    }
}
