using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _timeToLive;

    private float _timer;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _timer = _timeToLive;
        _rigidbody = GetComponent<Rigidbody>();
    }        

    void Update()
    {        
        _timer -= Time.deltaTime;

        if (_timer <= 0)
            Destroy(gameObject);

        Vector3 direction = transform.forward;
        _rigidbody.AddForce(direction * _speed * Time.deltaTime, ForceMode.Impulse);
    }
}
