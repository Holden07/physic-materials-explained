using UnityEngine;

public class CannonBall : MonoBehaviour
{
    private float destroyTime = 3f;
    private float timer = 0f;

    private void Update() {
        timer += Time.deltaTime;
        if (timer >= destroyTime) {
            Destroy(this.gameObject);
        }
    }
}
