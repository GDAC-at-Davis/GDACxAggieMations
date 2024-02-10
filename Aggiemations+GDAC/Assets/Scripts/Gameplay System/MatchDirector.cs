using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MatchDirector : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField]
    private ServiceContainerSO serviceContainer;

    [SerializeField]
    private MainCameraController mainCamera;

    [SerializeField]
    private MatchUI matchUI;

    [SerializeField]
    private ArenaMap map;

    [SerializeField]
    private int winningScore = 50;

    private List<PlayerInfo> playerInfos = new();
    private List<float> playerScores = new();

    private List<FighterManager> fighters = new();

    private bool gameEnded = false;

    private void Start()
    {
        map.SetArenaCameraActive(true);
        StartCoroutine(StartMatchCoroutine());
        serviceContainer.EventManager.OnPlayerHitByAttack += OnPlayerHitByAttack;
    }

    private void OnPlayerHitByAttack(int playerIndex, FighterCombatController.AttackInstance attackInstance)
    {
        if (gameEnded)
        {
            return;
        }

        playerScores[attackInstance.sourcePlayerIndex] += attackInstance.attackConfig.PointsAwarded;
        matchUI.UpdateScoreUI(attackInstance.sourcePlayerIndex,
            playerScores[attackInstance.sourcePlayerIndex] / winningScore);

        Debug.Log(playerScores[attackInstance.sourcePlayerIndex]);
        CheckForGameEnd();
    }

    private IEnumerator StartMatchCoroutine()
    {
        playerInfos = serviceContainer.PlayerInfoService.GetPlayerInfos();

        // Fast spawning for testing
        float delayMult = 1;
        foreach (var playerInfo in playerInfos)
        {
            if (playerInfo.SelectedFighterConfig.FastLoadForTest)
            {
                delayMult = 0;
            }
        }

        var spawnPoints = map.SpawnPoints;

        map.SetArenaCameraActive(true);

        yield return new WaitForSecondsRealtime(0.5f * delayMult);

        map.SetArenaCameraActive(false);

        for (var i = 0; i < playerInfos.Count; i++)
        {
            // Zoom in on spawn point
            spawnPoints[i].SetCameraActive(true);
            yield return new WaitForSecondsRealtime(1.25f * delayMult);

            // Spawn player
            var playerInfo = playerInfos[i];
            var fighterConfig = playerInfo.SelectedFighterConfig;

            var fighter = Instantiate(fighterConfig.FighterPrefab, Vector3.zero, Quaternion.identity);
            fighter.Initialize(i, fighterConfig, spawnPoints[i].GetPosition(), mainCamera);

            fighter.FlipSprite(spawnPoints[i].FlipSprite);

            fighter.SetControl(false);

            yield return new WaitForSecondsRealtime(1.7f * delayMult);

            fighters.Add(fighter);
            spawnPoints[i].SetCameraActive(false);

            playerScores.Add(0);
        }

        yield return new WaitForSeconds(1.5f * delayMult);

        matchUI.ShowMatchStartScreen();

        matchUI.InitializeScoreUI(serviceContainer.PlayerInfoService.GetPlayerInfos().Count);

        // Begin match
        foreach (var fighter in fighters)
        {
            fighter.SetControl(true);
        }
    }


    private void CheckForGameEnd()
    {
        var winningPlayerIndex = -1;
        for (var i = 0; i < playerScores.Count; i++)
        {
            if (playerScores[i] >= winningScore)
            {
                winningPlayerIndex = i;
                gameEnded = true;
                break;
            }
        }

        if (winningPlayerIndex != -1)
        {
            StartCoroutine(EndMatchCoroutine(winningPlayerIndex));
        }
    }

    private IEnumerator EndMatchCoroutine(int winningPlayerIndex)
    {
        foreach (var fighter in fighters)
        {
            fighter.SetControl(false);
        }

        yield return new WaitForSecondsRealtime(0.2f);

        Time.timeScale = 0.25f;

        yield return new WaitForSecondsRealtime(1.5f);

        Time.timeScale = 1f;

        yield return new WaitForSecondsRealtime(0.5f);

        matchUI.ShowMatchEndScreen(winningPlayerIndex);

        yield return new WaitForSecondsRealtime(4);
        serviceContainer.GameDirector.FinishGame();
    }
}