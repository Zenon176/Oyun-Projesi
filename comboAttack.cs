using UnityEngine;

public class comboAttack : MonoBehaviour
{
    Animator animator;
    int comboStep = 0;
    float lastClickTime;
    bool canCombo = false;
    public float comboDelay = 0.6f;



    [Header("Combo Ayarlarý")]
    public float maxComboDelay = 0.6f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            if (Time.time - lastClickTime > comboDelay){
                comboStep = 0; 
            }

            lastClickTime = Time.time;
            comboStep++;

            if (comboStep == 1){
                animator.SetTrigger("Attack1");
            }
            else if (comboStep == 2){
                animator.SetTrigger("Attack2");
            }
            else if (comboStep == 3){
                animator.SetTrigger("Attack3");
                comboStep = 0;
            }
        }
    }
    
}
