using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    [SerializeField] private string _spellName;
    [SerializeField] private ParticleSystem _effectPrefab;

    public string SpellName => _spellName;

    public abstract void Use(Character character);   
    
    protected void AddEffect(Transform effectPoint)
    {
        ParticleSystem effect = Instantiate(_effectPrefab, effectPoint.position, transform.rotation);
        effect.transform.SetParent(effectPoint, true);
        effect.Play();
    }
}
