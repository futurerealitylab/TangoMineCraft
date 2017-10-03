using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testfinding : MonoBehaviour {
    public GameObject crj;
    public bool isJoin;
	// Use this for initialization
	void Start () {
        crj = GameObject.Find("CreateRoomOrJoin");
        isJoin = crj.GetComponent<CreateRoomOrJoin>().isJoin;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
