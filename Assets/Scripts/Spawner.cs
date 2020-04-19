using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public GameObject prefab;
    public float requiredEmptyRadius;
    public UnityEngine.UI.Text clicktoStart;
    const int Left = 0;

    void Update() {
        if (Input.GetMouseButtonDown(Left)) {

            clicktoStart.enabled = false;

            Vector2 position =
                Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (!Physics2D.OverlapCircle(position, requiredEmptyRadius)) {
                Instantiate(prefab, position, Quaternion.identity);
            }
        }
    }


}
