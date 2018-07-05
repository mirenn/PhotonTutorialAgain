using System;
using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.MyCompany.MyGame
{
    public class GameManager1 : MonoBehaviour//=>1
    {
        static public GameManager1 Instance;
        #region Photon Messages

        /// <summary>
        /// Called when the local player left the room. We need to load the launcher scene.
        /// </summary>
        public void OnLeftRoom()//void void => void
        {
            SceneManager.LoadScene(0);
        }

        #endregion

        private void Start()
        {
            Instance = this;
        }
        #region Public Methods

        public void LeaveRoom()
        {
            PhotonNetwork.LeaveRoom();
        }

        #endregion
    }
}