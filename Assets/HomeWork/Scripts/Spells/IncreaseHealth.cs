using UnityEngine;

public class IncreaseHealth : Spell
{
    [SerializeField] public int _healthIncreaseAmount;

    public override void Use(Character character)
    {
        Health health = character.GetComponent<Health>();

        if (health == null)
        {
            Debug.Log("� �������� ������ ����������� ����������� ����������� ��������!");
            return;
        }

        health.IncreaseHealthCount(_healthIncreaseAmount);
        AddEffect(character.SpellEffectPoint);            
    }
}
