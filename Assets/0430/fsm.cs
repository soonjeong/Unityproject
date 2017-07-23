using System.Collections.Generic;
using UnityEngine;

public enum state
{
    Show,
    Match,
    Fail,
    Success,
    click
}

public class fsm : MonoBehaviour
{
    public List<GameObject> target;
    public int Length;
    public state phase = state.Show;
    List<int> showOrder = new List<int>();
    float time = 0;
    public int ShowIndex = 0;
    public int MatchIndex = 0;
    public GameObject FailUI;
    public GameObject SuccessUI;
    public GameObject over;

	// Use this for initialization
	void Start ()
    {
        InitOrder();
        over.SetActive(false);
        	
	}
	
    public void InitOrder()
    {
        showOrder.Clear();
        for (int i = 0; i< Length; i++)
        {
            showOrder.Add(Random.Range(0, target.Count));

        }
    }
	
	void Update ()
    {
	 if (phase == state.Show)
        {
            Show();
        }	
     else if (phase == state.Fail)
        {
            FailUI.SetActive(true);
        }
     
  
	}
    
    //함수들


    void Show()
    {
      
        time += Time.deltaTime;
        if (time < 3.0f)
        {

        }
        if (time > 3.0f)
        {
   
            time = 0;
            target[showOrder[ShowIndex]].GetComponent<examplemovement>().MoveStart();
            ShowIndex++;
        
        }
        if (ShowIndex == showOrder.Count)
        {
            phase = state.Match;
            ShowIndex = 0;

        }
    }

    public void Check(GameObject obj)
    {
        if (phase != state.Match)
        {
            return;
        }

        if (obj == target[showOrder[MatchIndex]])
        {
            MatchIndex++;

            if (MatchIndex == showOrder.Count)
            {
               
                
                SuccessUI.SetActive(true);
                
                phase = state.Success;
            }


        }


        else
        {
            phase = state.Fail;
            FailUI.SetActive(true);
            over.SetActive(true);

        }

    }

    public void success()
    {
        ShowIndex = 0;
        InitOrder();
        phase = state.Show;
        time = 0.0f;
        MatchIndex = 0;
        Length += 1;
        SuccessUI.SetActive(false);
    }

    public void Fail()
    {
        ShowIndex = 0;
        InitOrder();
        phase = state.Show;
        time = 0.0f;
        MatchIndex = 0;
        FailUI.SetActive(false);

    }
}
