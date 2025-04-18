using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _timeToLive;

    private float _timer;

    private void Awake()
        => _timer = _timeToLive;

    void Update()
    {        
        _timer -= Time.deltaTime;

        if (_timer <= 0)
            Destroy(gameObject);

        Vector3 direction = transform.forward.normalized * _speed * Time.deltaTime;
        transform.Translate(direction);
    }
}
