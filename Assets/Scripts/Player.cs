using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(x, y, 0f).normalized;

        _playerTransform.Translate(movement * _speed * Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft > 0)
        {
            Vector3 _plantPosition = new Vector3(_playerTransform.position.x, _playerTransform.position.y, 1);
            GameObject plant = Instantiate (_plantPrefab, _plantPosition, _playerTransform.rotation);
            plant.gameObject.SetActive(true);
            _numSeedsLeft -= 1;
            _numSeedsPlanted += 1;

            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
    }
}
