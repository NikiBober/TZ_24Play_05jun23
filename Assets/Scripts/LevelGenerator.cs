using UnityEngine;

public class LevelGenerator : Singleton<LevelGenerator>
{
    [SerializeField] GameObject _trackGroundPrefab;
    [SerializeField] GameObject _cubeWallPrefab;
    [SerializeField] GameObject _cubePickupPrefab;
    [SerializeField] Transform _initialTrackPosition;
    [SerializeField] private int _trackLenght = 30;
    [SerializeField] private int _maxWallHeight = 5;
    [SerializeField] private float _wallPosition = 25f;
    [SerializeField] private float _initialRowPosition = 0.5f;
    [SerializeField] private float _initialColumnPosition = -2f;
    [SerializeField] private float _cubeSize = 1f;
    [SerializeField] private Vector2 _pickupsAreaX;
    [SerializeField] private Vector2 _pickupsOffsetAreaZ;

    private Vector3 _trackPosition;
    private Vector3 _offset;
    private int _wallHeight;

    private void Start()
    {
        _trackPosition = _initialTrackPosition.position;
        _offset = Vector3.forward * _trackLenght;
        GenerateNewTrack();
    }

    public void GenerateNewTrack()
    {
        _trackPosition += _offset;
        Instantiate(_trackGroundPrefab, _trackPosition, Quaternion.identity);
        _wallPosition += _trackLenght;
        GenerateWall();
        GeneratePickups();
    }

    private void GenerateWall()
    {
        int columns = 5;

        for (int i = 0; i < columns; i++)
        {
            GenerateColumn(i);
        }
    }
    private void GenerateColumn(int columnIndex)
    {
        float columnPosition = _initialColumnPosition + _cubeSize * columnIndex;
        int rows = Random.Range(0, _maxWallHeight);

        for (int i = 0; i < rows; i++)
        {
            float rowPosition = _initialRowPosition + _cubeSize * i;
            Vector3 position = new Vector3(columnPosition, rowPosition, _wallPosition);
            Instantiate(_cubeWallPrefab, position, Quaternion.identity);
        }

        if (rows > _wallHeight)
        {
            _wallHeight = rows;
        }
    }

    private void GeneratePickups()
    {
        float positionZ = _trackPosition.z - _trackLenght / 2;

        for (int i = 0; i < _wallHeight; i++)
        {
            positionZ += Random.Range(_pickupsOffsetAreaZ.x, _pickupsOffsetAreaZ.y);
            Vector3 position = new Vector3(Random.Range(_pickupsAreaX.x, _pickupsAreaX.y), _initialRowPosition, positionZ);
            Instantiate(_cubePickupPrefab, position, Quaternion.identity);
        }

        _wallHeight = 0;
    }
}
