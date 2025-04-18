using UnityEngine;

public class IncreaseHealth : Spell
{
    [SerializeField] public int _healthIncreaseAmount;

    public override void Use(Character character)
    {
        base.Use(character);

        Health health = character.GetComponent<Health>();

        if (health != null)
            health.IncreaseHealthCount(_healthIncreaseAmount);
        else
            Debug.Log("У текущего игрока отсутствует возможность увеличивать здоровье!");
    }
}
