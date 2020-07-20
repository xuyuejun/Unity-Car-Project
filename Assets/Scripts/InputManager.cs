using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public bool l;
    public bool brake;
    
    // Update is called once per frame
    void Update()
    {
        l = Input.GetKeyDown(KeyCode.L);
        brake  = Input.GetKey(KeyCode.X);
    }
}
