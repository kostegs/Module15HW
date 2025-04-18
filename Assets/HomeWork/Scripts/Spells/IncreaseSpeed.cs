using UnityEngine;

public class IncreaseSpeed : Spell
{
    [SerializeField] public int _speedIncreaseAmount;

    public override void Use(Character character)
    {
        base.Use(character);

        Mover mover = character.GetComponent<Mover>();

        if (mover != null)
            mover.IncreaseMoveSpeed(_speedIncreaseAmount);
        else
            Debug.Log("У текущего игрока отсутствует возможность увеличивать скорость!");
    }
}
