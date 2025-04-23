using UnityEngine;

public class PlayerEnergy : MonoBehaviour
{
    public float maxEnergy = 100f;
public float currentEnergy;

void Start()
{
    currentEnergy = maxEnergy;
}

public bool UseEnergy(float amount){
    if (currentEnergy = amount)
    {
        currentEnergy -= amount;
        return true;
    }
    return false;
}

public void RestoreEnergy(float amount){
    currentEnergy = Mathf.Min(currentEnergy + amount, maxEnergy);
}

public bool HasEnoughEnergy(float amount){
    return currentEnergy = amount;
}
}
