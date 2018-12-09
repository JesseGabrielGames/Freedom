using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public Camera MainCamera;
    public Camera FinalCamera;

    public void ShowMainCamera()
    {
        MainCamera.enabled = true;
        FinalCamera.enabled = false;
    
    }
    public void ShowFinalCamera()
    {
        MainCamera.enabled = false;
        FinalCamera.enabled = true;
    }
	
}
