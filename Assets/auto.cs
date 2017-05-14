using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto : MonoBehaviour {

    public List<GameObject> Chickens;
    public List<int> MoveSequence = new List<int>();
    public int Length;
    int NowChicken = 0;
    public float time = 0;

	// Use this for initialization
	void Start ()
    {
        StartAutoMove();
        Chickens[MoveSequence[NowChicken]].GetComponent<examplemovement>().MoveStart();
    }
	
	// Update is called once per frame
	void Update ()
    {
      time += Time.deltaTime;
        if(time > 4.0f )
        {
            time = 0.0f;
            NowChicken = NowChicken + 1;
            Chickens[MoveSequence[NowChicken]].GetComponent<examplemovement>().MoveStart();
        }
	}

    public void StartAutoMove()
    {
        

        MoveSequence.Clear();
        for(int i=0; i < Length; i++)
        {
            MoveSequence.Add(Random.Range(0, 3));
        }
       
    }
}
