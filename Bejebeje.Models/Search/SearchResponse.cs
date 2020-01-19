﻿namespace Bejebeje.Models.Search
{
  using Bejebeje.Common.Enums;

  public class SearchResponse
  {
    public string Slug { get; set; }

    public string Name { get; set; }

    public int ImageId { get; set; }

    public ResultType ResultType { get; set; }
  }
}
