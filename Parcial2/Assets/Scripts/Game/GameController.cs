using Parcial2.Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private float tiempo1;
    [SerializeField]
    private float tiempo2;
    [SerializeField]
    private float tiempo3;

    private GameObject factory;
    private FactoryLowEnemy f_LowEnemy;
    private FactoryMedEnemy f_MedEnemy;

    private bool wave1 = false;
    private bool wave2 = false;

    // Use this for initialization
    void Start ()
    {

        factory = GameObject.FindGameObjectWithTag("Factory");
        f_LowEnemy = factory.GetComponent<FactoryLowEnemy>();
        f_MedEnemy = factory.GetComponent<FactoryMedEnemy>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time >= tiempo1 && wave1 == false)
        {
            f_LowEnemy.InstantiateEnemy();
            wave1 = true;
        }
        if (Time.time >= tiempo2 && wave2 == false)
        {
            f_MedEnemy.InstantiateEnemy();
            wave2 = true;
        }
	}
}
