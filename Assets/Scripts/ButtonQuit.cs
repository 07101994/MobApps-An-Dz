using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonQuit:MonoBehaviour {
  public void quitApp() {
    Debug.Log("ButtonQuit has been pressed");
    Application.Quit();
  }
}