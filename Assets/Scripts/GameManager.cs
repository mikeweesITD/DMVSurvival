using System.Diagnostics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    // Reference to the Player GameObject in the scene
    public GameObject player;

    private void Awake()
    {
        // Basic Singleton Pattern
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        // Keep GameManager between scene loads
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        UnityEngine.Debug.Log("GameManager initialized successfully.");

        if (player == null)
        {
            UnityEngine.Debug.LogWarning("GameManager: Player reference not assigned!");
        }
    }
}
