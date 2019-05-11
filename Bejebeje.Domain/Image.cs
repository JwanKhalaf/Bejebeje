﻿namespace Bejebeje.Domain
{
  using System;

  public class Image
  {
    public int Id { get; set; }

    public byte[] Data { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }
  }
}