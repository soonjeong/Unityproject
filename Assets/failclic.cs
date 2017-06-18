using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failclic : MonoBehaviour {
    public GameObject fsm;
        public void clickfailui()
    {
        fsm.GetComponent<fsm>().Fail();
    }

}
