using System.Text.Json;
using PolarDatat.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace PolarDatat.Api.Controllers;
[ApiController]
[Route("[controller]/[action]")]
public class PolarDatatController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly string _directory;

    public PolarDatatController(IConfiguration configuration)
    {
        _configuration = configuration;
        _directory = configuration.GetValue<string>("DataPath");
    }
    // for testing purposes
     [HttpGet(Name = "FileList")]
    public IEnumerable<string> ActivityFiles()
    {
    
        var fileStartsWith = "activity";
        
        var files = Directory.GetFiles(_directory, $"{fileStartsWith}*.json");
        
        return files;
        
    }
    //for testing purposes
    [HttpGet]
    public IEnumerable<string> DistinctStarts()
    {
    
        // get distinct first 7 letters of file names after last slash
        var files = Directory.GetFiles(_directory)
            .Select(f => f.Split('\\').Last())
            .Select(f => f.Substring(0, 7))
            .Distinct()
            .OrderBy(f => f);
    
    
        return files;
    }
    [HttpGet(Name = "GetOhrData")]
    public IEnumerable<OhrDto> OhrData()
    {

        var fileStartsWith = "247ohr";
        
//get first file with fileStarts with and read to class
        var files = Directory.GetFiles(_directory, $"{fileStartsWith}*.json");
        var ohrDatas = new List<OhrDto>();
        foreach (var file in files)
        {
        
            var json = System.IO.File.ReadAllText(file);
            
            var dailyOhr = JsonSerializer.Deserialize<DailyOhr>(json);
            
            var ohrData = GetOhrData(dailyOhr);
            ohrDatas.AddRange(ohrData);

        }
        return ohrDatas;


    }

    [HttpGet(Name = "GetSleepScores")]
    public IEnumerable<FlattenedSleepScore> SleepScores()
    {
        var fileStartsWith = "sleep_score";
        
        var files = Directory.GetFiles(_directory, $"{fileStartsWith}*.json");
        var sleepScores = new List<FlattenedSleepScore>();
        foreach (var file in files.Take(1))
        {
        
            var json = System.IO.File.ReadAllText(file);
            
            var dailySleepScore = JsonSerializer.Deserialize<SleepScore[]>(json);

            var flattenedSleepScores = dailySleepScore?.Select(x => new FlattenedSleepScore(x));
            
            sleepScores.AddRange(flattenedSleepScores);

        }
        return sleepScores;
    }

    private List<OhrDto> GetOhrData(DailyOhr ohrData)
    {
        var results = new List<OhrDto>();
        foreach (var ohrDataDeviceDay in ohrData.deviceDays)
        {
            foreach (var samples in ohrDataDeviceDay.samples)
            {
                var date = ohrDataDeviceDay.date;
                var time = TimeSpan.FromSeconds(samples.secondsFromDayStart);
                var dateTime = new DateTime(date.year, date.month, date.day, time.Hours, time.Minutes, time.Seconds);
                results.Add(new OhrDto
                {
                    Date = dateTime,
                    HeartRate = samples.heartRate,
                    Hour = time.Hours,
                    Minutes = time.Minutes
                });
            }
        }

        return results;
    }
    
    



}