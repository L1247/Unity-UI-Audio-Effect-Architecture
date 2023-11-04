#region

using UnityEngine;
using UnityEngine.Events;

#endregion

public class MVP_New_Model : MonoBehaviour
{
#region Public Variables

    public UnityAction<int> HealthChanged;

#endregion

#region Private Variables

    private int currentHealth;

    [SerializeField]
    [Min(1)]
    private int maxHealth;

#endregion

#region Unity events

    // Start is called before the first frame update
    private void Start()
    {
        SetHealth(maxHealth);
    }

#endregion

#region Public Methods

    public void TakeDamage()
    {
        var damage    = 10;
        var newHealth = currentHealth - damage;
        SetHealth(newHealth);
    }

#endregion

#region Private Methods

    private void SetHealth(int newHealth)
    {
        // change current health 
        currentHealth = newHealth;
        // raise healthChanged event.
        HealthChanged?.Invoke(currentHealth);
    }

#endregion
}