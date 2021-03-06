﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FacetFilterComponent.cs" company="Jonas Bergqvist">
//     Copyright © 2019 Jonas Bergqvist.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace BrilliantCut.Widget.Components
{
    using EPiServer.Shell.ViewComposition;

    /// <summary>
    /// Class FacetFilterComponent. This class cannot be inherited.
    /// Implements the <see cref="EPiServer.Shell.ViewComposition.ComponentDefinitionBase" />
    /// </summary>
    /// <seealso cref="EPiServer.Shell.ViewComposition.ComponentDefinitionBase" />
    [Component]
    public sealed class FacetFilterComponent : ComponentDefinitionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacetFilterComponent"/> class.
        /// </summary>
        public FacetFilterComponent()
            : base("brilliantcut/widget/facetfilter")
        {
            this.Title = "Catalog filter";
            this.Description = "Filters the catalog";
            this.SortOrder = 40;
            this.PlugInAreas = new[]
                                   {
                                       EPiServer.Shell.PlugInArea.AssetsDefaultGroup,
                                       EPiServer.Commerce.Shell.CommercePlugInArea.MarketingTools,
                                       EPiServer.Commerce.Shell.CommercePlugInArea.AssetsDefaultGroup
                                   };
            this.Categories = new[] { "commerce" };

            this.Settings.Add(new Setting("repositoryKey", "catalog"));
        }
    }
}