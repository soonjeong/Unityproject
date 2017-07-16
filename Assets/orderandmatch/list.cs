using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum function
{
    order,
    follow,
    match,
    success,
    fail
    
}
[System.Serializable]
public class boxes
{
    public string name;
    public GameObject box;
    public int values;
   
    
}
public class list : MonoBehaviour {
    public List<boxes> colorboxes;
    public GameObject order;
    public GameObject answer;
    public string commend;
    public int mixedvalue;
    public function phase = function.order;
    public string kakikomu;
    public int index1;
    public int index2;

	// Use this for initialization
	void Start () {

        index1 = Random.Range(0, 7);
        index2 = Random.Range(0, 7);
        
        phase = function.order;
	}
	
	// Update is called once per frame
	void Update () {

        if (phase == function.order)
        {
            numdis();
        }
        if (phase == function.match)
        {
              compare();
        }
        if (phase == function.follow)
        {
            storing();
        }
        if (phase == function.fail) {
            order.GetComponent<Text>().text = "다시 해봅시다";

                }
        if (phase == function.success)
        {
            order.GetComponent<Text>().text = "정답이에요~!";
        }
        
    
	}

    //함수들
    public void numdis()
    {
        order.GetComponent<Text>().text = colorboxes[index1].name + "과" + colorboxes[index2].name + "를" + "더해주세요";
        mixedvalue = colorboxes[index1].values + colorboxes[index2].values;
        phase = function.follow;
    }

    public void storing()
    {
        kakikomu = answer.GetComponent<Text>().text;
        
    }

    public void compare() {
        if (kakikomu == mixedvalue.ToString())
        {
            phase = function.success;
        }

        else
        {
            phase = function.fail;
        }
    }
    public void reset() {

        if (phase == function.success || phase == function.fail)
        {
            index1 = Random.Range(0, 7);
            index2 = Random.Range(0, 7);
            phase = function.order;
        }
         
        
    }

      
}
