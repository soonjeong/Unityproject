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

	// Use this for initialization
	void Start ()
    {
        InitOrder();
        	
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
     else if (phase == state.Success)
        {
            SuccessUI.SetActive(true);
            Length++;
        }
  
	}
    
    //함수들


    void Show()
    {
        time += Time.deltaTime;
        if (time > 1.0f)
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
                phase = state.Success;
                ShowIndex = 0;
            }

            else
            {
                MatchIndex = 0;
                phase = state.Fail;

            }

        }

 

    }

   

}
