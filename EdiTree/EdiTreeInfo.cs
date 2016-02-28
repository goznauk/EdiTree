﻿/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2016 EDIT Collective
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace EdiTree {
	public class EdiTreeInfo : GH_AssemblyInfo {
		public override string Name {
			get {
				return "EdiTree";
			}
		}
		public override Bitmap Icon {
			get {
				//Return a 24x24 pixel bitmap to represent this GHA library.
				return null;
			}
		}
		public override string Description {
			get {
				//Return a short string describing the purpose of this GHA library.
				return "";
			}
		}
		public override Guid Id {
			get {
				return new Guid("83412a6b-9f3e-4c8a-9e45-66ce03c4d31f");
			}
		}

		public override string AuthorName {
			get {
				//Return a string identifying you or your company.
				return "";
			}
		}
		public override string AuthorContact {
			get {
				//Return a string representing your preferred contact details.
				return "";
			}
		}
	}
}
