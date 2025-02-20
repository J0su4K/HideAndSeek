using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementPlayerComponent : MonoBehaviour
{
    [SerializeField] bool canMove = true, canRotate = true;
    [SerializeField] float moveSpeed = 10.0f;
    [SerializeField] float rotateSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveInput(InputAction _movement)
    {
        if (!canMove || _movement == null) return;
        Vector2 _moveDir = _movement.ReadValue<Vector2>();
        _moveDir.Normalize();
        Vector3 _addMove = new Vector3(_moveDir.x, 0, _moveDir.y) * moveSpeed;
        transform.position += _addMove;
    }

    public void RotateInput(InputAction _rotate)
    {
        Vector2 _rotDir = _rotate.ReadValue<Vector2>();
        if(!canRotate || _rotDir == Vector2.zero) return;
        Quaternion _newRotate = Quaternion.LookRotation(new Vector3(_rotDir.x, 0, _rotDir.y));
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _newRotate, Time.deltaTime * rotateSpeed);


    }
}
