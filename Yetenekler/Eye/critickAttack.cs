using UnityEngine;

public class CriticalStrikeMode : MonoBehaviour
{
    public float energyCostPerSecond = 10f;
    public KeyCode activateKey = KeyCode.LeftAlt;

    private PlayerEnergy playerEnergy;
    private bool isActive = false;

    private float timer = 0f;

    void Start()
    {
        playerEnergy = GetComponent<PlayerEnergy>();
    }

    void Update()
    {
        if (Input.GetKeyDown(activateKey))
        {
            if (!isActive && playerEnergy.HasEnoughEnergy(1f))
            {
                Activate();
            }
            else
            {
                Deactivate();
            }
        }

        if (isActive)
        {
            timer += Time.deltaTime;

            // Her saniye enerji harca
            if (timer >= 1f)
            {
                bool success = playerEnergy.UseEnergy(energyCostPerSecond);
                if (!success)
                {
                    Deactivate();
                    return;
                }
                timer = 0f;
            }
        }
    }

    void Activate()
    {
        isActive = true;
       //Debug.Log("Kritik Saldýrý Aktif!");

    }

    void Deactivate()
    {
        isActive = false;
        //Debug.Log("Kritik Saldýrý Kapalý!");
        
    }

    public bool IsActive()
    {
        return isActive;
    }
}
