﻿using System;
using System.Collections.Generic;

namespace FinalProject.Data;

public partial class Orderimg
{
    public int ImgId { get; set; }

    public int? OrderId { get; set; }

    public string? FPath { get; set; }

    public string? Notes { get; set; }
}
