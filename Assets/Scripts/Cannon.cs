using UnityEngine;

public class Cannon : MonoBehaviour
{
    private Rigidbody m_Rigidbody;
    public float m_Thrust = 200f;
    public GameObject cannonBallPrefab;
    public float sensitivity = 10f;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject cannonBall = Instantiate(cannonBallPrefab, new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z), Quaternion.identity);
            m_Rigidbody = cannonBall.GetComponent<Rigidbody>();
            m_Rigidbody.AddForce(Camera.main.transform.forward * m_Thrust);
        }
    }

    void FixedUpdate() {
        float horizontalAxis = Input.GetAxis("Mouse X");
        float verticalAxis = Input.GetAxis("Mouse Y");
        //Camera.main.transform.Rotate(-transform.up, horizontalAxis * sensitivity);
        Camera.main.transform.Rotate(transform.right, verticalAxis * sensitivity);
    }
}
