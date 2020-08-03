﻿using HandwritingLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Handwriting
{
    class Program
    {


        static void Main(string[] args)
        {
            //var fileData = File.ReadAllText("也.txt");
            //var rawStrokes = JsonConvert.DeserializeObject<List<List<List<double>>>>(fileData);
            //var strokes = RawStokeConverter.ParseData(rawStrokes);
            //var analyzer = new Analyzer(strokes);
            //var subStrokes = analyzer.AnalyzedStrokes;
            //var strokesCount = strokes.Count;
            //var subStrokesCount = subStrokes.Count;
            //int limit = 15;
            //var inputCharacter = fileData;

            //Console.WriteLine(strokesCount);
            //Console.WriteLine(subStrokesCount);

            //Matcher mt = new Matcher(strokesCount, subStrokesCount, limit);

            //mt.DoMatching();
            //mt.computeSubStrokeScore();
            //List<Object> GetList()
            //{
            //int numOfHieroglyph = mt.jarrayObj.Count;
            //for (int ix = 0; ix != numOfHieroglyph; ix++)
            //{
            //    var item = mt.jarrayObj[ix];
            //    mt.values.Add(item);
            //    continue;
            //}
            //foreach (Object x in mt.values)
            //{
            //    Console.WriteLine(x);
            //}

            //MatchCollector mc = new MatchCollector(limit);
            //mc.getMatches();

            MatchCollector mc = new MatchCollector(3);
            mc.AddMatch(new CharacterMatch('a', 0.42));
            mc.AddMatch(new CharacterMatch('b', 0.314));
            mc.AddMatch(new CharacterMatch('c', 0.4));
            mc.AddMatch(new CharacterMatch('d', 0.21));
            mc.AddMatch(new CharacterMatch('e', 0.9));
            char[] matches = mc.getMatches();
            foreach (char match in matches)
            {
                Console.WriteLine(match);
            }


        }
    }
}
    
