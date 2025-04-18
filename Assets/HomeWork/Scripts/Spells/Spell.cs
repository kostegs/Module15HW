using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    [SerializeField] private string _spellName;

    public string SpellName => _spellName;

    public virtual void Use(Character character)
    {
        Destroy(this.gameObject);
    }
}
