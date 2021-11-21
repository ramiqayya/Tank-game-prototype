using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
//[ExecuteInEditMode]
[AddComponentMenu("Coding Example/Syntax/hibbo/sandwitchfresh dashti kwayesh ")]
public class SampleCode : MonoBehaviour

{

    [Header("Player Setup ---------")]
    public string playerName;
   
    
    public enum Week { Saturday, Sunday, Monday, Tuesday, Wednesday,Thursday ,Friday}
    public Week week = Week.Monday;


    [Tooltip("0 to 100 for Player Health value")][Range(0,100)] public int playerHealth = 100;

    private void LateUpdate()
    {
        Debug.Log(" takeha hena solha alash hadshi");
    }
}
