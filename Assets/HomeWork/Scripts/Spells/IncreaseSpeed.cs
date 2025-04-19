using UnityEngine;

public class IncreaseSpeed : Spell
{
    [SerializeField] public int _speedIncreaseAmount;

    public override void Use(Character character)
    {
        Mover mover = character.GetComponent<Mover>();

        if (mover == null)
        {
            Debug.Log("У текущего игрока отсутствует возможность увеличивать скорость!");
            return;
        }

        mover.IncreaseMoveSpeed(_speedIncreaseAmount);
        AddEffect(character.SpellEffectPoint);            
    }
}
