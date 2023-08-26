namespace PolarDatat.Api.Models;

public class SleepScore
{
    public string night { get; set; }
    public SleepScoreResult sleepScoreResult { get; set; }
    public SleepScoreBaselines sleepScoreBaselines { get; set; }
}

public class SleepScoreResult
{
    public double sleepScore { get; set; }
    public double sleepTimeOwnTargetScore { get; set; }
    public double sleepTimeRecommendationScore { get; set; }
    public double continuityScore { get; set; }
    public double efficiencyScore { get; set; }
    public double remScore { get; set; }
    public double n3Score { get; set; }
    public double longInterruptionsScore { get; set; }
    public double groupDurationScore { get; set; }
    public double groupSolidityScore { get; set; }
    public double groupRefreshScore { get; set; }
    public int scoreRate { get; set; }
}

public class SleepScoreBaselines
{
    public int sleepTimeAverageMinutes { get; set; }
    public int longInterruptionsAverageTimeMinutes { get; set; }
    public double sleepTimeScoreBaseline { get; set; }
    public double groupSolidityScoreBaseline { get; set; }
    public double longInterruptionsScoreBaseline { get; set; }
    public double continuityScoreBaseline { get; set; }
    public double continuityScoreAverage { get; set; }
    public double efficiencyScoreBaseline { get; set; }
    public double efficiencyPercentAverage { get; set; }
    public double groupRefreshScoreBaseline { get; set; }
    public double remScoreBaseline { get; set; }
    public double remPercentAverage { get; set; }
    public double n3ScoreBaseline { get; set; }
    public double n3PercentAverage { get; set; }
    public double sleepScoreBaseline { get; set; }
}

public class FlattenedSleepScore
{
    public FlattenedSleepScore(SleepScore sleepScore)
    {
        Night = sleepScore.night;

        // Initialize properties from SleepScoreResult
        SleepScore = sleepScore.sleepScoreResult.sleepScore;
        SleepTimeOwnTargetScore = sleepScore.sleepScoreResult.sleepTimeOwnTargetScore;
        SleepTimeRecommendationScore = sleepScore.sleepScoreResult.sleepTimeRecommendationScore;
        ContinuityScore = sleepScore.sleepScoreResult.continuityScore;
        EfficiencyScore = sleepScore.sleepScoreResult.efficiencyScore;
        RemScore = sleepScore.sleepScoreResult.remScore;
        N3Score = sleepScore.sleepScoreResult.n3Score;
        LongInterruptionsScore = sleepScore.sleepScoreResult.longInterruptionsScore;
        GroupDurationScore = sleepScore.sleepScoreResult.groupDurationScore;
        GroupSolidityScore = sleepScore.sleepScoreResult.groupSolidityScore;
        GroupRefreshScore = sleepScore.sleepScoreResult.groupRefreshScore;
        ScoreRate = sleepScore.sleepScoreResult.scoreRate;

        // Initialize properties from SleepScoreBaselines
        SleepTimeAverageMinutes = sleepScore.sleepScoreBaselines.sleepTimeAverageMinutes;
        LongInterruptionsAverageTimeMinutes = sleepScore.sleepScoreBaselines.longInterruptionsAverageTimeMinutes;
        SleepTimeScoreBaseline = sleepScore.sleepScoreBaselines.sleepTimeScoreBaseline;
        GroupSolidityScoreBaseline = sleepScore.sleepScoreBaselines.groupSolidityScoreBaseline;
        LongInterruptionsScoreBaseline = sleepScore.sleepScoreBaselines.longInterruptionsScoreBaseline;
        ContinuityScoreBaseline = sleepScore.sleepScoreBaselines.continuityScoreBaseline;
        ContinuityScoreAverage = sleepScore.sleepScoreBaselines.continuityScoreAverage;
        EfficiencyScoreBaseline = sleepScore.sleepScoreBaselines.efficiencyScoreBaseline;
        EfficiencyPercentAverage = sleepScore.sleepScoreBaselines.efficiencyPercentAverage;
        GroupRefreshScoreBaseline = sleepScore.sleepScoreBaselines.groupRefreshScoreBaseline;
        RemScoreBaseline = sleepScore.sleepScoreBaselines.remScoreBaseline;
        RemPercentAverage = sleepScore.sleepScoreBaselines.remPercentAverage;
        N3ScoreBaseline = sleepScore.sleepScoreBaselines.n3ScoreBaseline;
        N3PercentAverage = sleepScore.sleepScoreBaselines.n3PercentAverage;
        SleepScoreBaseline = sleepScore.sleepScoreBaselines.sleepScoreBaseline;
    }

    public string Night { get; set; }

    // Properties from SleepScoreResult
    public double SleepScore { get; set; }
    public double SleepTimeOwnTargetScore { get; set; }
    public double SleepTimeRecommendationScore { get; set; }
    public double ContinuityScore { get; set; }
    public double EfficiencyScore { get; set; }
    public double RemScore { get; set; }
    public double N3Score { get; set; }
    public double LongInterruptionsScore { get; set; }
    public double GroupDurationScore { get; set; }
    public double GroupSolidityScore { get; set; }
    public double GroupRefreshScore { get; set; }
    public int ScoreRate { get; set; }

    // Properties from SleepScoreBaselines
    public int SleepTimeAverageMinutes { get; set; }
    public int LongInterruptionsAverageTimeMinutes { get; set; }
    public double SleepTimeScoreBaseline { get; set; }
    public double GroupSolidityScoreBaseline { get; set; }
    public double LongInterruptionsScoreBaseline { get; set; }
    public double ContinuityScoreBaseline { get; set; }
    public double ContinuityScoreAverage { get; set; }
    public double EfficiencyScoreBaseline { get; set; }
    public double EfficiencyPercentAverage { get; set; }
    public double GroupRefreshScoreBaseline { get; set; }
    public double RemScoreBaseline { get; set; }
    public double RemPercentAverage { get; set; }
    public double N3ScoreBaseline { get; set; }
    public double N3PercentAverage { get; set; }
    public double SleepScoreBaseline { get; set; }
}