using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int damage = 1000; // 충돌 데미지
    public float maxFuel = 100f;
    public float currentFuel;

    public float usage; //사용량()

    public FuelBar fuelBar;
    // Start is called before the first frame update
    void Start()
    {
        currentFuel = maxFuel;
        fuelBar.SetMaxFuel(maxFuel);
    }

    // Update is called once per frame
    void Update()
    {
        currentFuel -= usage;
        fuelBar.SetFuel(currentFuel);
        
    }

    
    // Player 가 EnemyCar와 충돌 시 Damage 입음(연료 소비)
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyCar"))
        {
            TakeDamage(damage);
        }
    }
    public void TakeDamage(int damage)  
    {
        currentFuel -= damage;
        fuelBar.SetFuel(currentFuel);
    }
}
