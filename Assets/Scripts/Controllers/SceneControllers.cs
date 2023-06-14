using InnerProtocol;
using MoonShooter.Models;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MoonShooter.Controllers
{
    public class SceneControllers : MonoBehaviour
    {
        [SerializeField] private SceneModelData sceneModelData;

        private SceneModel sceneModel;

        private void Awake()
        {
            GenerateCrystals();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
                ReloadScene();
        }

        private void GenerateCrystals()
        {
            int spawnCount = Random.Range(sceneModelData.MinCrystalsInScene, sceneModelData.MaxCrystalsInScene);
            for (int i = 0; i < spawnCount; i++)
            {
                var position = Random.insideUnitCircle * sceneModelData.SizeSpawnZone;
                var crystal = Instantiate(sceneModelData.CrystalPrefab, new Vector3(position.x, 0, position.y), Quaternion.AngleAxis(Random.Range(0, 360), Vector3.up));
            }
        }

        private void ReloadScene()
        {
            Translator.RemoveAll();
            SceneManager.LoadScene(0);
        }
    }
}