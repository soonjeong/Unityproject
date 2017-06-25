using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum function
{
    product,
    sum,
    match,
    success.
    fail
    
}
public class list : MonoBehaviour {
    public List<GameObject> colorboxes;
    public List<int> colornumber = new List<int>();
    public GameObject order;
    public GameObject answer;
    public string commend;
    public string box1;
    public string box2;
    

	// Use this for initialization
	void Start () {
        colornumber.Clear();
        colornumber.Add(Random.Range(0, 7));

	}
	
	// Update is called once per frame
	void Update () {

        order.GetComponent<Text>().text = box1+"과"+box2+"를"+commend+"주세요";

	}


}
