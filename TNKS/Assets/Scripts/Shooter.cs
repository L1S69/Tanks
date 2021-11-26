using System.Collections;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _bulletSpawn;
    [SerializeField] private TankSounds _tankSounds;

    [SerializeField] private float _power;

    private IEnumerator _coroutine;
    public void Shoot()
    {
        GameObject _bullet = Instantiate(_bulletPrefab, _bulletSpawn.position, _bulletSpawn.rotation);
        _bullet.GetComponent<Rigidbody>().AddForce(transform.forward * _power);
        _tankSounds.PlayShootSound();
        _coroutine = DestroyBullet(_bullet);
        StartCoroutine(_coroutine);
    }

    private IEnumerator DestroyBullet(GameObject _bullet) 
    {
        yield return new WaitForSeconds(10);
        Destroy(_bullet);
        yield return null;
    }
}
