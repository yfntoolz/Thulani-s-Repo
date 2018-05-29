using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Result
/// </summary>
public class Result
{
    public int Id { get; set; }
    public string Research { get; set; }
    public string Graph { get; set; }

	public Result(int id, string research, string graph)
	{
        this.Id = id;
        this.Research = research;
        this.Graph = graph;
	}
}