using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int vidaMaxima;
    public int vidaAtual;

    // Use this for initialization
    void Start()
    {
        vidaAtual = vidaMaxima;

    }

    // Update is called once per frame
    void Update()
    {
        if (vidaAtual <= 0)
        {
            Destroy(gameObject);


        }

    }

    public void HurtEnemy(int damageToGive)
    {
        vidaAtual -= damageToGive;
    }
    public void SetMaxHealth()
    {
        vidaAtual = vidaMaxima;

    }
}

