using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private TankMovement _tankMovement;
    [SerializeField] private Shooter _shooter;

    private Vector3 _movement;
    private float _rotation;

    private float _horizontal;
    private float _vertical;

    private void Update() 
    {
        _movement = GetInput();
        _rotation = GetRotation();

        _tankMovement.Move(_movement);
        if (_rotation != 42)
        _tankMovement.SetRotation(_rotation);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            _shooter.Shoot();
        }
    }

    private Vector3 GetInput() 
    {
        if (_vertical == 0) _horizontal = Input.GetAxisRaw("Horizontal");
        if (_horizontal == 0) _vertical = Input.GetAxisRaw("Vertical");

        _movement = new Vector3(_horizontal, 0, _vertical);

        return _movement;
    }

    private float GetRotation() 
    {
        int _angle = 42;

        if (_vertical > 0) _angle = 0;
        if (_vertical < 0) _angle = 180;
        if (_horizontal > 0) _angle = 90;
        if (_horizontal < 0) _angle = -90;

        return _angle;
    }
}
