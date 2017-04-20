using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Track:MonoBehaviour, ITrackableEventHandler {
  private TrackableBehaviour mTrackableBehaviour;

  void Start() {
    mTrackableBehaviour = GetComponent<TrackableBehaviour>();
    if (mTrackableBehaviour) {
      mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }
    OnTrackingLost();
  }
  public void OnTrackableStateChanged(
				  TrackableBehaviour.Status previousStatus,
				  TrackableBehaviour.Status newStatus) {
    if (newStatus == TrackableBehaviour.Status.DETECTED ||
	newStatus == TrackableBehaviour.Status.TRACKED) {
      OnTrackingFound();
    }
    else {
      OnTrackingLost();
    }
  }
  private void OnTrackingFound() {
    //AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
    //AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");

    //Invoke the "showMessage" method in our Android Plugin Activity
    //string message = "CUSTOM: Detected trackable: " + mTrackableBehaviour.TrackableName;
    Debug.LogWarning("CUSTOM: Detected trackable: " + mTrackableBehaviour.TrackableName);
    //jo.Call("showMessage", message);
  }
  private void OnTrackingLost() {
  }
}
