using UnityEngine;
using UnityEngine.InputSystem;

public class fireball : MonoBehaviour
{
    public GameObject spawn;
    public GameObject spawnRot;
    public GameObject objectPrefab; 
    // The prefab to instantiate
    public float forceAmount = 500f;
    // The amount of force to apply
    private InputAction onFireAction;
    Rigidbody rb;
    public bool cast;

    private Animator animator; 
    void Start()
    {
        // Get the Animator component attached to the GameObject 
        animator = GetComponent<Animator>();
        
        cast = true;
    }
   
    void Update()
    {
       // animator.SetBool("Cast", false);
    }

 void MyFunction()
    {
        GameObject newObject = Instantiate(objectPrefab, spawn.transform.position, spawnRot.transform.rotation);
        rb = newObject.GetComponent<Rigidbody>();
        if (rb != null)
        {

            rb.AddForce(spawnRot.transform.forward * forceAmount);
        }
        animator.SetBool("Cast", false);
        cast = true;
    }

public void OnFire()
    {
        Debug.Log("Function called after 1 second");
        // Instantiate the object at the position and rotation of the spawner
        // Get the Rigidbody component of the new object Rigidbody
        if (cast)
        {
            cast = false;
            
            animator.SetBool("Cast", true);
            Invoke("MyFunction", 0.8f);
        }
        

    }


    }
