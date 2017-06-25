using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickui : MonoBehaviour
{
    public GameObject fsm;
    public void Click()
    {
        fsm.GetComponent<fsm>().success();

    }
}