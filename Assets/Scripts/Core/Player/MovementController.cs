using UnityEngine;
using Zenject;
using  Core.Settings.Difficulty;

public class MovementController : MonoBehaviour
{
    private float _moveSpeed;
    private DifficultyManager difficultyManager;

    [Inject]
    public void Init(DifficultyManager difficultyManager)
    {
        this.difficultyManager = difficultyManager;
        _moveSpeed = this.difficultyManager.CurrentSettings._playerSpeed;
    }
    
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");   

        Vector3 move = new Vector3(moveX, 0, moveZ);

        if (move.magnitude > 1f)
        {
            move.Normalize();
        }

        transform.Translate(move * _moveSpeed * Time.deltaTime, Space.World);
    }
}
