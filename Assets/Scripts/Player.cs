using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //연료
    public float maxFuel = 100f; 
    public float currentFuel;
    public FuelBar fuelBar;

    //내구도
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    public int damage = 20; // 충돌 대미지
    public float usage; //연료 사용량()

    void Start()
    {
        //연료 초기화
        currentFuel = maxFuel;
        fuelBar.SetMaxFuel(maxFuel);

        //내구도 초기화
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
        //연료 소비
        currentFuel -= usage;
        fuelBar.SetFuel(currentFuel);
        
    }

    
    // Player 가 EnemyCar와 충돌 시 Damage 입음(내구도 감소)
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyCar"))
        {
            TakeDamage(damage);
        }
    }
    public void TakeDamage(int damage)  
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
