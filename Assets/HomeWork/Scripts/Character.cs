using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Transform _gunPoint;
    [SerializeField] private Transform _spellEffectPoint;
    
    public Transform GunPoint => _gunPoint;
    public Transform SpellEffectPoint => _spellEffectPoint;
}
