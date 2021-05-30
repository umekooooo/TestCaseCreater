using System;
using System.Collections.Generic;
using System.Text;

namespace TestCaseCreater
{
    public class TestCases
    {
        private int _id;
        private int _subId;
        private string _title;
        private Dictionary<string, List<string>> _valueRanges;
        private List<TestCase> _items;

        public string Title
        {
            get { return _title; }
        }
        public string Factors
        {
            get { return string.Join("\n", _valueRanges.Keys); }
        }
        public string Items
        {
            get { return string.Join("\n", _items); }
        }

        public TestCases(int id, int subId, string title, Dictionary<string, List<string>> valueRanges)
        {
            this._id = id;
            this._subId = subId;
            this._title = title;
            this._valueRanges = valueRanges;

            this._items = GenerateTestCase(_id, _subId, valueRanges);

            var i = 1;
            foreach(var t in _items)
            {
                t.SubSubId = i++;
            }
        }

        private List<TestCase> GenerateTestCase(int id, int subId, Dictionary<string, List<string>> valueRanges)
        {
            if (valueRanges.Count <= 0) return new List<TestCase>();

            var testCaseList = new List<TestCase>();
            testCaseList.Add(new TestCase(id, subId, 1));

            foreach(var valueName in valueRanges.Keys)
            {
                var newTestCaseList = new List<TestCase>();
                foreach (var testCase in testCaseList)
                {
                    foreach (var value in valueRanges[valueName])
                    {
                        newTestCaseList.Add(new TestCase(testCase, valueName, value));
                    }
                }
                testCaseList = newTestCaseList;
            }

            return testCaseList;
        }


        public override string ToString()
        {
            return $"{Title}\n{Factors}\n{Items}";
        }
    }
}
