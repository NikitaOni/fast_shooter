using UnityEngine;

public class Minimap : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _cameraPlayer;

    private void LateUpdate()
    {
        Vector3 newPosition = _player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f, _cameraPlayer.eulerAngles.y, 0f);
    }
}
