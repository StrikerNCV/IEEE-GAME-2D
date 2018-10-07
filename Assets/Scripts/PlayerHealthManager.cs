using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    public int vidaMaxima;
    public int vidaAtual;

	// Use this for initialization
	void Start () {
        vidaAtual = vidaMaxima;
		
	}
	
	// Update is called once per frame
	void Update () {
        if(vidaAtual <= 0)
        {
            gameObject.SetActive(false);

            
        }
		
	}

    public void HurtPlayer(int damageToGive)
    {
        vidaAtual -= damageToGive;
    }
    public void SetMaxHealth()
    {
        vidaAtual = vidaMaxima;

    }
}
