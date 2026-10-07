using UnityEngine;

public class DeletarInimigo : MonoBehaviour
{

        void OnTriggerEnter(Collider other)
        {
            // Verifica se o objeto atingido tem a tag "Enemy"
            if (other.CompareTag("Enemy"))
            {
                // Destrói o inimigo
                Destroy(other.gameObject);           
            Destroy(gameObject);
            }

            // Destrói a bala após colidir com qualquer coisa (ou você pode colocar dentro do if se preferir que ela só destrua ao acertar o inimigo)

        }
    }


