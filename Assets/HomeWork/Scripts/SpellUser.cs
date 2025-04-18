using UnityEngine;

public class SpellUser : MonoBehaviour
{
    [SerializeField] private Character _character;
    [SerializeField] private SpellCollector _spellCollector;
    [SerializeField] private UserInput _userInput;

    private void Update()
    {
        if (_userInput.SpellKeyPressed)
        {
            Spell currentSpell = _spellCollector.CurrentSpell;

            if(currentSpell == null)
            {
                Debug.Log("У персонажа нет предметов для использования");
                return;
            }

            currentSpell.Use(_character);
            _spellCollector.RemoveCurrentSpell();
        }
    }
}
