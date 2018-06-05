using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_MachineLearning
{
    public class IrisData
    {
        [Column("0")]
        public float SepalLength;

        [Column("1")]
        public float SepalWidth;

        [Column("2")]
        public float PetalLength;

        [Column("3")]
        public float PetalWidth;

        [Column("4")]
        [ColumnName("Label")]
        public string Label;
    }
}
