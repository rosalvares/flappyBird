using UnityEngine;

public class SpawnerController : MonoBehaviour{
    
    public GameObject backgroundPrefabs;
    public GameObject darkBackgroundPrefabs;
    public GameObject pipesPrefabs;
    public GameObject pipesRedPrefabs;
    [Range(0, 0.85f)]
    public float height;
    public float maxTime = 1f;
    public float maxTimeBackground = 10f;

    private float _timer = 0;
    private float _timerBackground = 0;
    private int whichBackground = 0;

    private void Start(){
        SpawnBackground(0f, 15f);
    }
    private void Update(){
        if (_timer > maxTime){
            SpawnPipes();
            _timer = 0;
        }
        _timer += Time.deltaTime;

        if (_timerBackground > maxTimeBackground){
            SpawnBackground(3f, 17.5f);
            _timerBackground = 0;
        }
        _timerBackground += Time.deltaTime;
    }

    private void SpawnPipes(){
        var y = Random.Range(-height, height);
        var instance = Instantiate(pipesPrefabs);
        instance.transform.position = new Vector3(transform.position.x, y, 0);
        Destroy(instance, 10f);
    }

    private void SpawnBackground(float x, float timeToDestroy){
        if (whichBackground == 0){
            whichBackground = Random.Range(1, 3);
        }
        GameObject choosenBackground = backgroundPrefabs;
        
        if (whichBackground == 1){
            choosenBackground = backgroundPrefabs;
        }else{
            choosenBackground = darkBackgroundPrefabs;
        }

        var instance = Instantiate(choosenBackground);
        instance.transform.position = new Vector3(x, 0, 0);
        Destroy(instance, timeToDestroy);
    }
}
