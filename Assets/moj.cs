using UnityEngine;

public class moj : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Pobierz obiekt, z którym dosz³o do kolizji
        GameObject collidedObject = collision.gameObject;
        // Wyœwietl nazwê obiektu, z którym dosz³o do kolizji
        Debug.Log("Zderzenie z: " + collidedObject.name);
    }

}
