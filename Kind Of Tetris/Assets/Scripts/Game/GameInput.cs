using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum ControlStatus
{
    moving,
    rotating
}

public class GameInput : MonoBehaviour
{
    private GameManager manager;
    private GamePlay controls;
    private ControlStatus status = ControlStatus.moving;

    private void Awake()
    {
        controls = new GamePlay();

        controls.GamePlayControls.Place.performed += ctx => Place();

        controls.GamePlayControls.SwitchStatus.performed += ctx => SwitchStatus();

        controls.GamePlayControls.NextPiece.performed += ctx => manager.NextPiece();
        controls.GamePlayControls.PrevPiece.performed += ctx => manager.PrevPiece();
        controls.GamePlayControls.ChangePiece.performed += ctx => changePiece(ctx.ReadValue<float>());

        controls.GamePlayControls.East.performed += ctx => directionInput(Cardinal.east);
        controls.GamePlayControls.West.performed += ctx => directionInput(Cardinal.west);
        controls.GamePlayControls.North.performed += ctx => directionInput(Cardinal.north);
        controls.GamePlayControls.South.performed += ctx => directionInput(Cardinal.south);
        controls.GamePlayControls.Up.performed += ctx => directionInput(Cardinal.up);
        controls.GamePlayControls.Down.performed += ctx => directionInput(Cardinal.down);
   
    }

    private void Start()
    {
        manager = GetComponent<GameManager>();
    }

    private void OnEnable()
    {
        controls.GamePlayControls.Enable();
    }

    private void OnDisable()
    {
        controls.GamePlayControls.Disable();
    }

    void directionInput(Cardinal c)
    {
        switch (status)
        {
            case ControlStatus.moving:
                manager.MoveSelected((Move)c);
                break;
            case ControlStatus.rotating:
                manager.RotateSelected((Rotate)c);
                break;
            default:
                break;
        }
    }

    void SwitchStatus()
    {
        switch (status)
        {
            case ControlStatus.moving:
                status = ControlStatus.rotating;
                break;
            case ControlStatus.rotating:
                status = ControlStatus.moving;
                break;
            default:
                break;
        }
    }

    void Place()
    {
        if (manager.CanPlacePiece())
            manager.PlacePiece();
        else if (manager.CanTakePiece())
        {
            manager.TakePiece();
        }
    }


    void changePiece(float dir)
    {
        if (dir > 0)
        {
            manager.NextPiece();
        } else
        {
            manager.PrevPiece();
        }
    }

}
