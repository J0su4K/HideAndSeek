using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHideComponent : MonoBehaviour
{
    IAA_Player controls;
    InputAction movement = null;
    InputAction takeObject = null;

    public InputAction Movement => movement;
    public InputAction TakeObject => takeObject;

    private void Awake()
    {
        controls = new IAA_Player();
    }

    private void OnEnable()
    {
        movement = controls.HidingPlayer.Movement;
        takeObject = controls.HidingPlayer.TakeObject;

        movement.Enable();
        takeObject.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
        takeObject.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
