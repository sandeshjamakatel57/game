using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject aiAgentPrefab;  // Prefab of the AI agent to spawn
    public string playerTag = "Player";  // Tag of the player's object
    public float spawnRadius = 80f;  // Radius within which the AI agents will spawn
    public int numAgentsToSpawn = 5;  // Number of AI agents to spawn

    void Start()
    {
        // Find the player's object based on the specified tag
        GameObject playerObject = GameObject.FindGameObjectWithTag(playerTag);

        if (playerObject != null)
        {
            // Get the position of the player's object
            Vector3 playerPosition = playerObject.transform.position;

            for (int i = 0; i < numAgentsToSpawn; i++)
            {
                // Generate a random position within the spawn radius
                Vector3 spawnPosition = Random.insideUnitSphere * spawnRadius;
                spawnPosition += playerPosition;

                // Ensure that the spawned AI agent is at the same height as the player's object
                spawnPosition.y = playerPosition.y;

                // Spawn the AI agent at the generated position
                GameObject spawnedAgent = Instantiate(aiAgentPrefab, spawnPosition, Quaternion.identity);
            }
        }
        else
        {
            Debug.LogError("Player object not found!");
        }
    }
}

