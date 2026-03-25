using UnityEngine;

public class Cube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log(other.name + " has hit the box.");
    }
}
