using UnityEngine;

public class TimeSlow : MonoBehaviour
{
    // Bu yetenek zamanýn yavaþlamasýný saðlar.
    public KeyCode slowKey = KeyCode.LeftShift;
    public float worldTimeScale = 0.4f;
    public float playerSpeedScale = 0.2f;
    public float energyDrainPerSecond = 10f;
    public float maxEnergy = 100f;

    private float currentEnergy;
    private bool isSlowing = false;
    private float originalFixedDelta;
    private float originalPlayerSpeed = 1f;

    private Animator animator;
    private PlayerControl playerControl;

    void Start()
    {
        currentEnergy = maxEnergy;
        originalFixedDelta = Time.fixedDeltaTime;

        animator = GetComponent<Animator>();
        playerControl = GetComponent<PlayerControl>();
    }

    void Update()
    {
        if (Input.GetKeyDown(slowKey) && currentEnergy > 0f)
        {
            ActivateTimeSlow();
        }

        if (Input.GetKey(slowKey) && isSlowing)
        {
            currentEnergy -= energyDrainPerSecond * Time.unscaledDeltaTime;
            if (currentEnergy <= 0f)
            {
                currentEnergy = 0f;
                DeactivateTimeSlow();
            }
        }

        if (Input.GetKeyUp(slowKey) && isSlowing)
        {
            DeactivateTimeSlow();
        }
    }

    void ActivateTimeSlow()
    {
        Time.timeScale = worldTimeScale;
        Time.fixedDeltaTime = originalFixedDelta * Time.timeScale;

        animator.speed = playerSpeedScale / worldTimeScale; 
        if (playerControl != null)
        {
            playerControl.SetSpeedMultiplier(playerSpeedScale / worldTimeScale); 
        }

        isSlowing = true;
       // Debug.Log("Zaman yavaþlatýldý (düþmanlar 0.4x, oyuncu 0.2x)");
    }

    void DeactivateTimeSlow()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = originalFixedDelta;

        animator.speed = 1f;
        if (playerControl != null)
        {
            playerControl.SetSpeedMultiplier(1f);
        }

        isSlowing = false;
       // Debug.Log("Zaman normale döndü.");
    }


}
