using UnityEngine;

public class TankMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private TankSounds _tankSounds;
    [SerializeField] private float _speed;

    private Vector3 _temp;

    public void Move(Vector3 _movement) => _rigidbody.MovePosition(_rigidbody.position + (_movement * _speed));

    public void SetRotation(float _rotation) => transform.localEulerAngles = new Vector3(0, _rotation, 0);

    private void Start()
    {
        _temp = transform.position;
    }

    private void Update()
    {
        if (transform.position != _temp)
        {
            _tankSounds.PlayMovementSound();
        }
        else 
        {
            _tankSounds.StopMovementSound();
        }

        _temp = transform.position;
    }
}
