// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;

namespace Kewb
{
	public class LanguageString
	{
		public LanguageString ()
		{

		}

		int position = -1;

		[XmlAttribute("page")]
		public string Page{ get; set; }

		[XmlAttribute("key")]
		public string Key{ get; set; }

		public string Value{ get; set; }
	}
}