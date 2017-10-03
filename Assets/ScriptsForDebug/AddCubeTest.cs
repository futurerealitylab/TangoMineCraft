using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class AddCubeTest : MonoBehaviour {
    public GameObject cube;
    public Camera cam;

    public float m_cubeSize;
	// Use this for initialization
	void Start () {
        m_cubeSize = cube.transform.lossyScale.x;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,
                               out hitInfo))
            {
                AddCube(hitInfo);
                Debug.Log(hitInfo.transform.gameObject.name);
            }
        }
    }

    public void AddCube(RaycastHit hitInfo)
    {
        
        Vector3 center = (hitInfo.point / m_cubeSize) + (hitInfo.normal * m_cubeSize);
        float x = Mathf.Floor(center.x + m_cubeSize);
        float y = Mathf.Floor(center.y + m_cubeSize);
        float z = Mathf.Floor(center.z + m_cubeSize);
        center.x = x;
        center.y = y;
        center.z = z;
        Debug.Log(center);
        //Vector3 p = (center * m_cubeSize) - new Vector3(0.0f, m_cubeSize / 2.0f, 0.0f);
        Vector3 p = center * m_cubeSize;
        GameObject obj = Instantiate(cube, p, Quaternion.identity) as GameObject;
    }
}
