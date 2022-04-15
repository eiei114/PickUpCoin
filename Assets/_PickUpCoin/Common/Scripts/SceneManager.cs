using UnityEngine.Internal;
using UnityEngine.SceneManagement;

namespace Manager.Scene
{
    public static class SceneManager
    {
        /// <summary>
        /// シーンを映る
        /// </summary>
        /// <param name="sceneEnum"></param>
        /// SceneManager.LoadScene(SceneEnum.Title)でタイトルシーンに移る
        /// Titleの部分を移りたいシーン名に変更するとよい
        public static void LoadScene(SceneEnum sceneEnum)
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync($"_Scenes/{sceneEnum}");
        }

        public static void LoadScene(SceneEnum sceneEnum, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync($"_Scenes/{sceneEnum}", mode);
        }
    }
}