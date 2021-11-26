using UnityEngine;

public class TankSounds : MonoBehaviour
{
    [SerializeField] private AudioSource _shootSound;
    [SerializeField] private AudioSource _movementSound;

    public void PlayShootSound() 
    {
        _shootSound.Play();
    }

    public void PlayMovementSound() 
    {
        if (!_movementSound.isPlaying)
        {
            _movementSound.Play();
        }
    }

    public void StopMovementSound() 
    {
        if (_movementSound.isPlaying)
        {
            _movementSound.Pause();
        }
    }
}
