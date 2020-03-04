using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private MapManager map = null;
    [SerializeField] private GameInput input = null;

    [SerializeField] private List<GameObject> presentPieces = new List<GameObject>();
    [SerializeField] private List<GameObject> placedPieces = new List<GameObject>();
    private int pieceNb = 0;

    private GameObject selectedPiece = null;
    private Piece selectedScript = null;

    private MapCube pointedBlock = null;

    public LayerMask layerMask = 1 << 8;

    public bool end = false;

    [SerializeField] private TextMeshProUGUI text;

    void Start()
    {
        changeSelectedPiece(presentPieces[pieceNb]);
        input = GetComponent<GameInput>();
        if (map == null)
        {
            map = GameObject.Find("/Map").GetComponent<MapManager>();
        }
        if (text == null)
        {
            text = GameObject.Find("Victory").GetComponent<TextMeshProUGUI>();
        }
        text.enabled = false;

    }

    void Update()
    {
        InGame();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            map.setRowActivated(1, false);
        }
    }

    void InGame()
    {
        gameRaycast();
        if (selectedPiece != null) {
            if (pointedBlock != null)
            {
                selectedPiece.transform.position = pointedBlock.transform.position + selectedScript.offset;
            } else {
                selectedScript.GoToInitPos();
            }
        }
    }

    void gameRaycast()
    {
        RaycastHit[] m_results = new RaycastHit[5];
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (pointedBlock)
        {
            pointedBlock.UnPoint();
        }
        pointedBlock = null;
        if (Physics.RaycastNonAlloc(ray, m_results, 100.0f, layerMask) > 0)
        {
            float min_d = 999;
            for (int i = m_results.Length - 1; i >= 0; --i)
            {
                if (m_results[i].collider != null)
                {

                    if (m_results[i].collider.transform.CompareTag("MapCube"))
                    {
                        MapCube pointed = m_results[i].collider.GetComponent<MapCube>();
                        if (pointed.isActivated() && m_results[i].distance <= min_d)
                        {
                            min_d = m_results[i].distance;
                            if (pointedBlock)
                            {
                                pointedBlock.UnPoint();
                            }
                            pointedBlock = pointed;
                            pointedBlock.Point();
                        }
                    }
                }
            }
        }
    }

    // the child is when you pick a piece to know wich subPiece is followed
    public void changeSelectedPiece(GameObject newg, GameObject child=null)
    {
        if (newg == null)
        {
            selectedPiece = null;
            selectedScript = null;
        }
        else
        {
            //put the piece away
            if (selectedPiece != null)
            {
                selectedScript.GoToInitPos();
            }
            selectedPiece = newg;
            selectedScript = selectedPiece.GetComponent<Piece>();
            if (child != null)
                selectedScript.actual = child;
        }
    }

    public bool CanPlacePiece()
    {
        return pointedBlock != null && !pointedBlock.filled && selectedPiece != null && selectedScript.ok;
    }

    public bool CanTakePiece()
    {
        return pointedBlock != null && selectedPiece == null && pointedBlock.filled;
    }

    public void PlacePiece()
    {
        selectedScript.PlacePiece(true);
        placedPieces.Add(selectedPiece);
        presentPieces.Remove(selectedPiece);
        changeSelectedPiece(null);
        if (presentPieces.Count > 0)
        {
            if (pieceNb >= presentPieces.Count - 1)
                PrevPiece();
            changeSelectedPiece(presentPieces[pieceNb]);
        }
        if (end = map.CheckVictory())
        {
            GameWon();
        }
    }

    public void GameWon()
    {
        text.enabled = true;
        input.enabled = false;
        //to be changed
        GameObject.Find("Main Camera").GetComponent<CameraMovement>().enabled = false;
    }

    public void TakePiece()
    {
        if (pointedBlock != null)
        {
            MapCube pointed = pointedBlock.GetComponent<MapCube>();
            changeSelectedPiece(pointed.containing.transform.parent.gameObject, pointed.containing);
            selectedScript.PlacePiece(false);
            presentPieces.Add(selectedPiece);
            placedPieces.Remove(selectedPiece);
        }
    }

    public void MoveSelected(Move m)
    {
        if (selectedPiece != null && selectedScript != null)
        {
            selectedScript.MoveRef(m);
        }
    }

    public void RotateSelected(Rotate r)
    {
        if (selectedPiece != null && selectedScript != null)
        {
            selectedScript.RotateRef(r);
        }
    }

    public void NextPiece()
    {
        if (pieceNb < presentPieces.Count - 1)
        {
            pieceNb++;
            changeSelectedPiece(presentPieces[pieceNb]);
        }
    }

    public void PrevPiece()
    {
        if (pieceNb > 0)
        {
            pieceNb--;
            changeSelectedPiece(presentPieces[pieceNb]);
        }
    }
}
