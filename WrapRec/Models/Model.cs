﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrapRec.Data;
using WrapRec.Evaluation;

namespace WrapRec.Models
{
	public abstract class Model : IModel
	{
		public string Id { get; set; }
        public int PureTrainTime { get; protected set; }
        public int PureEvaluationTime { get; protected set; }
        public Dictionary<string, string> AllParameters { get; protected set; }
		public abstract void Setup(Dictionary<string, string> modelParams);
		public abstract void Train(Split split);
		public abstract void Evaluate(Split split, EvaluationContext context);
        public abstract void Clear();
	}
}
