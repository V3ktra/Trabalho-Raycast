using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizar : MonoBehaviour
{
    public GameObject sphere;
    public int gerador;
    public float cooldown_esquerda = 0.0f;
    public float cooldown_direita = 0.0f;
    public float cooldown_cima = 0.0f;
    public float cooldown_baixo = 0.0f;
      // Update is called once per frame
    void Update()
    {
        //int x = Random.Range;
        //int y = Random.Range;
        //int z = Random.Range;

        cooldown_baixo += Time.deltaTime;
        cooldown_esquerda += Time.deltaTime;
        cooldown_direita += Time.deltaTime;
        cooldown_cima += Time.deltaTime;

        if(cooldown_esquerda>=2.0)
        {
            Vector3 randomSpawnPosition = new Vector3(-55, 5f, Random.Range(-40, 40));
            
            
            Instantiate(sphere,randomSpawnPosition,Quaternion.identity);
            cooldown_esquerda = 0.0f;
        }

         if(cooldown_direita>=5.0)
        {
            Vector3 randomSpawnPosition = new Vector3(55, 5f, Random.Range(-40, 40));
            
            
            Instantiate(sphere,randomSpawnPosition,Quaternion.identity);
            cooldown_direita = 0.0f;
        }
        
        if(cooldown_baixo>=3.0)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(40, -40), 5f, -55);
            
            
            Instantiate(sphere,randomSpawnPosition,Quaternion.identity);
            cooldown_baixo = 0.0f;
        }
        
        if(cooldown_cima>=6.0)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(40, -40), 5f, 55);
            
            
            Instantiate(sphere,randomSpawnPosition,Quaternion.identity);
            cooldown_cima = 0.0f;
        }
    }
}
