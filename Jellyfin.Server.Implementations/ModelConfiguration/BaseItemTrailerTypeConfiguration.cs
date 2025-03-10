using System;
using System.Linq;
using Jellyfin.Data.Entities;
using MediaBrowser.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQLitePCL;

namespace Jellyfin.Server.Implementations.ModelConfiguration;

/// <summary>
/// Provides configuration for the BaseItemMetadataField entity.
/// </summary>
public class BaseItemTrailerTypeConfiguration : IEntityTypeConfiguration<BaseItemTrailerType>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<BaseItemTrailerType> builder)
    {
        builder.HasKey(e => new { e.Id, e.ItemId });
        builder.HasOne(e => e.Item);
    }
}
