using System;
using System.Collections.Generic;
using System.Text;

namespace TestCaseCreater
{
    public class TestCase
    {
        private int _id;
        private int _subId;
        private int _subSubId;
        private Dictionary<string,string> _values;

        /// <summary>
        /// このテストケースのIDを取得します。
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// このテストケースのサブIDを取得します。
        /// </summary>
        public int SubId
        {
            get { return _subId; }
            set { _subId = value; }
        }
        /// <summary>
        /// このテストケースのサブサブIDを取得します。
        /// </summary>
        public int SubSubId
        {
            get { return _subSubId; }
            set { _subSubId = value; }
        }
        /// <summary>
        /// このテストケースの観点名-観点値の組み合わせを返します。
        /// </summary>
        public Dictionary<string, string> Values
        {
            get { return _values; }
            set { _values = value; }
        }

        /// <summary>
        /// 空のテストケースを生成します。
        /// </summary>
        /// <param name="id">テストケースのID</param>
        /// <param name="subId">テストケースのサブID</param>
        /// <param name="subSubId">テストケースのサブサブID</param>
        public TestCase(int id, int subId, int subSubId)
        {
            this._id = id;
            this._subId = subId;
            this._subSubId = subSubId;
            this._values = new Dictionary<string, string>();
        }
        /// <summary>
        /// テストケースを生成します。
        /// </summary>
        /// <param name="id">テストケースのID</param>
        /// <param name="subId">テストケースのサブID</param>
        /// <param name="subSubId">テストケースのサブサブID</param>
        /// <param name="values">テストケースの観点名-観点値の組み合わせ</param>
        public TestCase(int id, int subId, int subSubId, Dictionary<string,string> values)
        {
            this._id = id;
            this._subId = subId;
            this._subSubId = subSubId;
            this._values = new Dictionary<string, string>(values);
        }
        /// <summary>
        /// 既存のテストケースに観点名-観点値を追加して新しいテストケースを生成します。
        /// </summary>
        /// <param name="testCase">べースとするテストケース</param>
        /// <param name="valueName">観点名</param>
        /// <param name="value">観点値</param>
        public TestCase(TestCase testCase, string valueName, string value)
        {
            this._id = testCase.Id;
            this._subId = testCase.SubId;
            this._values = new Dictionary<string, string>(testCase.Values);
            _values.Add(valueName, value);
        }
        /// <summary>
        /// テストケースに観点名-観点値の組み合わせを追加します。
        /// </summary>
        /// <param name="valueName">観点名</param>
        /// <param name="value">観点値</param>
        public void AddValue(string valueName, string value)
        {
            _values.Add(valueName, value);
        }
        /// <summary>
        /// テストケースを「id-subid:value1,value2,value3,…」として返します。
        /// 例："1-2-1:0,128,teststr"
        /// </summary>
        /// <returns>成形した文字列</returns>
        override public string ToString()
        {
            return $"{_id}-{_subId}-{_subSubId},{string.Join(",", _values.Values)}";
        }
    }
}
