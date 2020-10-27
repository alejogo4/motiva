using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FocusMode : MonoBehaviour {

    private void Start()
    {
        modoContinuousAuto();
    }

    //enfoque automatico
    public void modoContinuousAuto () {
		CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
	}
    
	//enfoque por defecto
	public void modoNormal () {
		CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_NORMAL);
	}

	//enfoque manual
	public void modoTriggerAuto () {
		CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
	}

}
