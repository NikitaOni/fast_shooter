using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem;

public class Pivot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var center = Screen.safeArea.center;
        Mouse.current.WarpCursorPosition(center);
        InputState.Change(Mouse.current.position, center);
        transform.Rotate(0, -180, 0);
    }

    
}
