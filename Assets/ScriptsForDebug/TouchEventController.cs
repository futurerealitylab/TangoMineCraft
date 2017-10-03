using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchEventController : MonoBehaviour {
    public Camera cam;
    public GameObject test;
    public MultiplayerCubeStackerUIController cubeManager;
    // Use this for initialization
    void Start () {
       
    }
    public void setCam(Camera _cam)
    {
        cam = _cam;
    }
	// Update is called once per frame
	void Update () {
     
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // Check if finger is over a UI element
            //Debug.Log(test.transform.lossyScale.x);
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
            {
                //AndroidHelper.ShowAndroidToastMessage("touched UI");
            }
            else
            {

                RaycastHit hitInfo;
                Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                if (Physics.Raycast(ray,
                                out hitInfo))
                {
                    //string name = hitInfo.transform.gameObject.name;
                    //AndroidHelper.ShowAndroidToastMessage(name);
                    cubeManager.AddCube(hitInfo);
                }
                else
                {
                    //AndroidHelper.ShowAndroidToastMessage("touchWithoutNAME");
                }
            }
        }
    }
}
