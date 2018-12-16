﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
	public interface IControlModel
	{
		string name { get; }
		string type { get; }
		string cssClass { get; }
		string isHidden { get; }
	}
}
