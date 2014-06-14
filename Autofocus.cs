using UnityEngine;
public class Autofocus : MonoBehaviour
{

	private bool mEnableAutofocus = false;
	private bool mDisableAutoFocus = false;

	// Use this for initialization
	void Start ()
	{
	}

	void OnGUI ()
	{

		if (GUI.Button (new Rect (50, Screen.height - 125, 200, 100), "Enable Autofocus")) {
			mEnableAutofocus = true;
		}

		if (GUI.Button (new Rect (300, Screen.height - 125, 200, 100), "Disable Autofocus")) {
			mDisableAutoFocus = true;
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (mEnableAutofocus) {

			bool success = CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);

			if (success) {
				Debug.Log ("Successfully set the continuous autofocus");
			} else {
				Debug.Log ("Unable to set the continuous autofocus");
			}

			mEnableAutofocus = false;

		}

		if (mDisableAutoFocus) {

			bool success = CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_INFINITY);
			
			if (success) {
				Debug.Log ("Successfully set the infinity focus mode");
			} else {
				Debug.Log ("Unable to set the infinity focus mode");
			}

			mDisableAutoFocus = false;

		}
	}
}
