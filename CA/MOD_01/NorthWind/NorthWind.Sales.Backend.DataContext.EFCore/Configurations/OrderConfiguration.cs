﻿namespace NorthWind.Sales.Backend.DataContext.EFCore.Configurations;
internal class OrderConfiguration :
    IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Property(o => o.CustumerId)
            .IsRequired()
            .HasMaxLength(5)
            .IsFixedLength();

        builder.Property(o => o.ShipAddress)
            .IsRequired()
            .HasMaxLength(60);

        builder.Property(o => o.ShipCity)
            .HasMaxLength(15);

        builder.Property(o => o.ShipCountry)
            .HasMaxLength (15);

        builder.Property(o => o.ShipPostalCode)
            .HasMaxLength(10);

    }
}
