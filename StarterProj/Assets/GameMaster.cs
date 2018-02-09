using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gameMaster;
    public TestMoveStructure testMoveStructure;
    public TerrainSettings terrainSettings;
    public ScriptableParticle ParticleSystemSelector;
    public Vector3 PlayerPosition;
    public TerrainBiome terrainBiome;
    public TerrainManager terrainManager;
    public GameObject TrackerObject;
    // Use this for initialization
    void Awake()
    {
        testMoveStructure = ScriptableObject.CreateInstance<TestMoveStructure>();
        terrainSettings = ScriptableObject.CreateInstance<TerrainSettings>();
        testMoveStructure = ScriptableObject.CreateInstance<TestMoveStructure>();
        ParticleSystemSelector = ScriptableObject.CreateInstance<ScriptableParticle>();
        terrainBiome = ScriptableObject.CreateInstance<TerrainBiome>();
        terrainManager = ScriptableObject.CreateInstance<TerrainManager>();
        if (gameMaster != this)
        {
            gameMaster = this;
        }
        DontDestroyOnLoad(this);

        TerrainExtensions.CreateTerrain(new Vector3(0,0,0));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
