using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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
}
