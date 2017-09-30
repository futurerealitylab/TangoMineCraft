using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRoomOrJoin : MonoBehaviour {
    public bool isJoin = false;
    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
