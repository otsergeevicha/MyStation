using Plugins.MonoCache;
using Reflex.Core;
using UnityEngine.SceneManagement;

namespace Infrastructure.Reflex
{
    public class Loader : MonoCache
    {
        private const string SceneName = "Main";
        
        private void Start()
        {
            Scene scene = SceneManager.LoadScene(SceneName, new LoadSceneParameters(LoadSceneMode.Single));
            
            ReflexSceneManager.PreInstallScene(scene, builder =>
                builder.AddInstance(""));
        }
    }
}