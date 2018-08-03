var numberOfWords = 8_000_000;

var start = new DateTime(2014, 4, 22, 16, 30, 0);
var now = new DateTime(2018, 7, 3, 0, 0, 0);

var diff = now - start;
var days = diff.TotalDays;
var hours = diff.TotalHours;
var minutes = diff.TotalMinutes;
var seconds = diff.TotalSeconds;

Console.WriteLine(numberOfWords / minutes);
Console.WriteLine(numberOfWords / seconds);