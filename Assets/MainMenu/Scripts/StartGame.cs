using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartGameButton()
    {
        var center = Screen.safeArea.center;
        Mouse.current.WarpCursorPosition(center);
        InputState.Change(Mouse.current.position, center);
        Cursor.lockState = CursorLockMode.Locked;
        if(LevelCount.levelCount < 10) {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
        
    }
}
