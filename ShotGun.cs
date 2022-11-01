using UnityEngine;

public class ShotGun : Weapon
{
    [SerializeField] private int _amountBullets;

    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < _amountBullets; i++)
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
    }
}
