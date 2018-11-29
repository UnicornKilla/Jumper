using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public Transform player;
    [SerializeField]
    private float speed = 10f;

    void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);       
        player.position = Vector2.MoveTowards (player.position, new Vector2(mousePos.x, player.position.y), speed * Time.deltaTime);
    }
}
