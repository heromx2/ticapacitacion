﻿namespace NorthWind.Sales.Backend.DataContext.EFCore.Options;

public class DBOptions
{
    public const string SectionKey = nameof(DBOptions);
    public string ConnectionString { get; set; }
}
