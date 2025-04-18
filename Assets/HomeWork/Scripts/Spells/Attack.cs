using UnityEngine;

public class Attack : Spell
{
    [SerializeField] private Projectile _projectile;

    public override void Use(Character gameObject)
    {
        base.Use(gameObject);

        Projectile projectile = Instantiate(_projectile, transform.position, transform.rotation);        
    }
}
