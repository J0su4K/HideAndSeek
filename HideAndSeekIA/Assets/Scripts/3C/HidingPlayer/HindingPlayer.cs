using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Profiling;

public class HindingPlayer : MonoBehaviour
{
    [SerializeField] MovementPlayerComponent movement = null;
    [SerializeField] InputHideComponent inputs = null;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (movement)
        {
            movement.MoveInput(inputs.Movement);
            movement.RotateInput(inputs.Movement);
        }

    }

    void Init()
    {
        movement = GetComponent<MovementPlayerComponent>();
        inputs = GetComponent<InputHideComponent>();
    }
}
