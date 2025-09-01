using UnityEngine;
using System; // per Action

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] ballPrefabs;

    // Se non ti serve uno spawnPoint fisso, puoi togliere questo e usare solo Vector3 random
    [SerializeField] private Transform spawnPoint;

    // Evento basato su Action
    public event Action OnSpawnBall;

    private void Start()
    {
        // Sottoscrivo lo spawn random
        OnSpawnBall += SpawnRandomBall;

        // Avvio il ciclo che spawna 3 palle al secondo
        StartCoroutine(SpawnLoop());
    }

    private System.Collections.IEnumerator SpawnLoop()
    {
        // 3 palle al secondo = una ogni 1/3 secondi
        float interval = 2f / 3f;

        while (true) // loop infinito
        {
            OnSpawnBall?.Invoke();
            yield return new WaitForSeconds(interval);
        }
    }

    private void SpawnRandomBall()
    {
        int index = UnityEngine.Random.Range(0, ballPrefabs.Length);

        // Se hai definito uno spawnPoint randomizzabile
        Vector3 spawnPosition = new Vector3(
            UnityEngine.Random.Range(-14.0f, 14.0f), // X random
            14.8f,                                  // Y fisso
            3.39f                                   // Z fisso
        );

        Instantiate(ballPrefabs[index], spawnPosition, Quaternion.identity);
    }
}
