using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public Transform player;

    void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        player.position = new Vector2(mousePos.x, player.position.y);
    }
}
