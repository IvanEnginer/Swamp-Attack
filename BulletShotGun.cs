using UnityEngine;

public class BulletShotGun : Bullet
{
    private Vector2 _direction;
    private float _maximumRandomDirection = 0.2f;

    private void Start()
    {
        float Random = UnityEngine.Random.Range(0, _maximumRandomDirection );

        _derection = new Vector2(-1f, Random);
    }

    private void Update()
    {
        transform.Translate(_derection * _speed * Time.deltaTime, Space.World);
    }
}
