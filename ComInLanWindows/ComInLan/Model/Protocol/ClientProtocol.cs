﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComInLan.Model.Protocol
{
	public class ClientProtocol : IClientProtocol
	{
		public ClientCommand Command { get; set; }

		public object Data { get; set; }
	}
}
