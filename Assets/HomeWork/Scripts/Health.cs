using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _healthCount;

    public void IncreaseHealthCount(int healthCount)
    {
        if (healthCount <= 0)
            return;

        _healthCount += healthCount;

        Debug.Log($"Здоровье было увеличено. Новая величина: {_healthCount}");
    }
}
