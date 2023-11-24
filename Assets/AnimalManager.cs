using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{

    [SerializeField] private GameObject[] animals;

    protected void Start()
    {
        SpawnAnimals();
    }

    // ABSTRACTION
    protected void SpawnAnimals()
    {
        for (int i = 0; i < animals.Length; i++)
        {
            Instantiate(animals[i]);
        }
    }
}
