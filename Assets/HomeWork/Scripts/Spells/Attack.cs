using UnityEngine;

public class Attack : Spell
{
    [SerializeField] private Projectile _projectile;    

    public override void Use(Character character)
    {
        Projectile projectile = Instantiate(_projectile, character.GunPoint.position, transform.rotation);
        AddEffect(projectile.transform);
    }
}
