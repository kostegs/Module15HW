using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class SpellCollector : MonoBehaviour
{
    [SerializeField] private Transform _spellStorageTransform;

    private Spell _currentSpell;

    public Spell CurrentSpell => _currentSpell;

    private void OnTriggerEnter(Collider other)
    {
        if (_currentSpell != null && _currentSpell.gameObject != null)
            return;

        Spell spell = other.gameObject.GetComponent<Spell>();

        if (spell != null)
        {
            _currentSpell = spell;
            other.gameObject.transform.parent = _spellStorageTransform;
            other.gameObject.transform.localPosition = Vector3.zero;
            other.gameObject.transform.localRotation = Quaternion.identity;
            Debug.Log($"Вы подобрали навык: {_currentSpell.SpellName}");
        }            
    }

    public void RemoveCurrentSpell() => _currentSpell = null;    

}
