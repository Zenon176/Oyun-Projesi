using UnityEngine;

public class ShieldAbility : MonoBehaviour
{
    //Bu yetenek karakterin savunma tu�una bas�ld���nda hasar enerjiyi azaltacak �ekilde ayarl�yor.
    private PlayerEnergy playerEnergy;
    private PlayerHealth playerHealth;

    public bool shieldActive = true;

    void Start()
    {
        playerEnergy = GetComponent<PlayerEnergy>();
        playerHealth = GetComponent<PlayerHealth>();
    }
    ausing UnityEngine;

    public class ShieldAbility : MonoBehaviour
    {
        private PlayerEnergy playerEnergy;
        private PlayerHealth playerHealth;

        private bool isShieldActive = false;

        void Start()
        {
            playerEnergy = GetComponent<PlayerEnergy>();
            playerHealth = GetComponent<PlayerHealth>();
        }

        void Update()
        {
            // E tu�una bas�ld���nda kalkan a��l�r/kapan�r
            if (Input.GetKeyDown(KeyCode.E))
            {
                isShieldActive = !isShieldActive;
                //Debug.Log("Kalkan " + (isShieldActive ? "AKT�F" : "PAS�F"));
            }
        }

        
        public void TakeDamage(float damage)
        {
            if (isShieldActive && playerEnergy.CurrentEnergy > 0)
            {
                float remainingDamage = damage;

                if (playerEnergy.CurrentEnergy >= damage)
                {
                    playerEnergy.UseEnergy(damage);
                    remainingDamage = 0f;
                }
                else
                {
                    remainingDamage -= playerEnergy.CurrentEnergy;
                    playerEnergy.UseEnergy(playerEnergy.CurrentEnergy);
                }

                if (remainingDamage > 0f)
                {
                    playerHealth.TakeDamage(remainingDamage);
                }
            }
            else
            {

                playerHealth.TakeDamage(damage);
            }
        }

        public bool IsShieldActive()
        {
            return isShieldActive;
        }
    }

    public void TakeDamage(float amount)
    {
        if (shieldActive && playerEnergy.CurrentEnergy > 0)
        {
            float remainingDamage = amount;

            if (playerEnergy.CurrentEnergy >= amount)
            {
                playerEnergy.UseEnergy(amount);
                remainingDamage = 0f;
            }
            else
            {
                remainingDamage -= playerEnergy.CurrentEnergy;
                playerEnergy.UseEnergy(playerEnergy.CurrentEnergy);
            }

            if (remainingDamage > 0f)
            {
                playerHealth.TakeDamage(remainingDamage);
            }
        }
        else
        
            playerHealth.TakeDamage(amount);
        }
    }
}
