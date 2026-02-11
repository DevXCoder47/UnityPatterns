using ServiceLocatorNamespace;
using System;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float _speed;

    private IMovingService _movingService;
    private ITurningService _turningService;

    void Start()
    {
        try
        {
            _movingService = ServiceLocator.Get<IMovingService>();
            _turningService = ServiceLocator.Get<ITurningService>();
        }
        catch (Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    void Update()
    {
        _movingService.MoveForward(gameObject, _speed);
        _turningService.TurnRight(gameObject, _speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        _movingService.StopMovement(gameObject);
    }
}
