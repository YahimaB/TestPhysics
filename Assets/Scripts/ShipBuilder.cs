using UnityEngine;

public class ShipBuilder : MonoBehaviour
{
    [SerializeField] private int _width;
    [SerializeField] private int _height;

    [SerializeField] private Transform _cellsContainer;
    [SerializeField] private GameObject _battleCellPrefab;

    private void Awake()
    {
        SpawnCells();
    }

    private void SpawnCells()
    {
        var minX = _width / -2.0f + 0.5f; //leftmost point
        var minY = _height / -2.0f + 0.5f; //lowest point

        for (var x = minX; x < minX + _width; x++)
        {
            var row = "";
            for (var y = minY; y < minY + _height; y++)
            {
                row += $"{x};{y} | ";
                var pos = new Vector3(x, y, 0.0f);
                // Instantiate(_battleCellPrefab, pos, new Quaternion(), _cellsContainer);
                var cell = Instantiate(_battleCellPrefab, _cellsContainer);
                cell.transform.SetLocalPositionAndRotation(pos, new Quaternion());
            }
            
            //Debug.LogError(row);
        }
    }
}
