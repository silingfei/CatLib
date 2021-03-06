﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using CatLib.API.Exception;

namespace CatLib.API.Crypt{

	public class DecryptException : RunTimeException {

		public DecryptException(string message) : base(message){}

	}

}