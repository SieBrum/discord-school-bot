﻿
namespace DiscordBotSchool.Mapping
{
    public enum CoinflipResults
    {
        Won,
        Lost,
        NoPoints,
        UnknownError
    }

    public enum CoinflipVsResults
    {
        ChallengerWon,
        EnemyWon,
        ChallengerNoPoints,
        EnemyNoPoints,
        ChallengeAlreadyExists,
        ChallengeRequestSet,
        ChallengeDoesntExist,
        ChallengeDeclined,
        UnknownError
    }

    public class CoinflipResult
    {
        public BackendUser User;
        public int ChosenSide;
        public CoinflipResults Result;
    }
}
