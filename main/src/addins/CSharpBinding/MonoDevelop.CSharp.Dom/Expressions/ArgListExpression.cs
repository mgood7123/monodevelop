// 
// ArgListExpression.cs
//  
// Author:
//       Mike Krüger <mkrueger@novell.com>
// 
// Copyright (c) 2010 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Collections.Generic;

namespace MonoDevelop.CSharp.Dom
{
	/// <summary>
	/// Represents the undocumented __arglist keyword.
	/// </summary>
	public class ArgListExpression : DomNode
	{
		public override NodeType NodeType {
			get {
				return NodeType.Expression;
			}
		}

		public bool IsAccess { // access is __arglist, otherwise it's __arlist (a1, a2, ..., an)
			get;
			set;
		}
		
		public CSharpTokenNode Keyword {
			get { return (CSharpTokenNode)GetChildByRole (Roles.Keyword) ?? CSharpTokenNode.Null; }
		}
		
		public CSharpTokenNode LPar {
			get { return (CSharpTokenNode)GetChildByRole (Roles.LPar) ?? CSharpTokenNode.Null; }
		}
		
		public CSharpTokenNode RPar {
			get { return (CSharpTokenNode)GetChildByRole (Roles.RPar) ?? CSharpTokenNode.Null; }
		}
		
		public IEnumerable<DomNode> Arguments {
			get { return GetChildrenByRole (Roles.Argument); }
		}
		
		public override S AcceptVisitor<T, S> (DomVisitor<T, S> visitor, T data)
		{
			return visitor.VisitArgListExpression (this, data);
		}
	}
}

