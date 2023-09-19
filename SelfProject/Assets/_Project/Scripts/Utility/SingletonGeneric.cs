using Unity.VisualScripting;
using UnityEngine;

public class SingletonGeneric<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    // The public getter to access the instance
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();
                if (instance == null)
                {
                    Debug.LogError("Singleton instance of type " + typeof(T) + " not found in the scene.");
                }
            }
            return instance;
        }
    }

    // Optional: Add a flag to specify if the Singleton persists between scenes
    // This can be helpful if you want a Singleton to persist during scene changes.
    public bool persistBetweenScenes = false;

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;

            if (persistBetweenScenes)
            {
                DontDestroyOnLoad(gameObject);
            }
        }
        else
        {
            // If an instance already exists, destroy this one
            Destroy(gameObject);
        }
    }

    // Optional: Implement an OnDestroy method to handle cleanup or reset logic
    protected virtual void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }
}