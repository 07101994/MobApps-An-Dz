/* Script to quit the app by pressing the Quit Button
 * Created by: Aleksandr Anfilov. Author: https://www.youtube.com/watch?v=4-X1FDylROA&t=1s
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonQuit:MonoBehaviour {
  public void quitApp() {
    Debug.Log("ButtonQuit has been pressed");
    Application.Quit();
  }
}